using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace macdoc
{
    public class DBHelper
    {

        public static string Users = "users";
        public static string Machine = "machine";
        public static string Staff_activity = "staff_activity";
        public static string Files = "files";

        public static string SelectComponentNumber(string selected_component, string selected_machine)
        {
            string compnum = "";
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {

                    if (Equals(selected_component, "Vérin"))
                    {
                        selected_component = "verin";
                    }

                    connection.Open();

                    string composants_num = "select" +
                               " count(id_machine) as counts from " + selected_component + " inner join machine on id_machine =" +
                                "machine.id  where machine.nom = '" + selected_machine + "'; ";

                    SQLiteCommand cmd = new SQLiteCommand(composants_num, connection);

                    compnum = cmd.ExecuteScalar().ToString();



                }
                else
                {
                    connection.Close();

                }

            }

            return compnum;

        }
        public static int InsertIntoFiles(string id,string name, string user_id , string path
            ,DateTime time,string id_machine)
        {

            int file_id = 0;

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                connection.Open();
                SQLiteCommand insert_cmd = new SQLiteCommand("insert into files(id,name,path,id_machine,created_at,created_by)"
                    +" values('"+id+"','"+name+"','"+path+"',"+id_machine+",'"+time+"',"+user_id+")",connection);


                file_id =  insert_cmd.ExecuteNonQuery();

                connection.Close();
            }

            
            return file_id;
        }

        public static void SelectFilesByID(MetroGrid grid, string id_machine)
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                connection.Open();
                string command = "select replace(name,files.id||'.pdf','') as nom ," +
                    "created_at as \"ajouté le\"  , users.nom as \"ajouté par \" , machine.nom as \" machine \" , path as \"Répertoire\" from files " +
                    "inner join machine on id_machine = machine.id inner join users on users.id = created_by where id_machine = "
                    + id_machine + ";";

                SQLiteDataAdapter select = new SQLiteDataAdapter(command,connection);

                DataTable dataTable = new DataTable();
                select.Fill(dataTable);
                grid.DataSource = dataTable;
                connection.Close();

            }
        }
        public static void SelectMachineByType(MetroGrid grid, string type)
        {
            string sqlcommand = "select nom ,type , reference, date_installation as \"date d'installation\" from machine"
                + " where type = '" + type + "';";


            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                connection.Open();




                SQLiteCommand cmd = new SQLiteCommand(sqlcommand, connection);



                grid.Refresh();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grid.DataSource = dataTable;

                connection.Close();


            }
        }

        public static void FillHomeGrid(MetroGrid metroGrid1,string selection,string selected_machine)
        {

            string sqlcommand = "select " + selection + ".id, " + selection + ".nom , " + selection + ".reference , date_insertion as \"date d'insertion\", date_modification as \"date " +
                    "de modification\" , life_duration as \"durée de vie\" , num_modification as \"nombre de modifications \"  from " + selection + " inner join machine on machine.id = " +
                    selection + ".id_machine where machine.nom = '" + selected_machine + "';";

            if (Equals(selection, "Vérin"))
            {

                selection = "verin";
                sqlcommand = "select nom , reference , dernier_vidange as \"dernier vidange\" , huil_durée as \"huile longevité\" from " + selection + ";";

            }


            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand(sqlcommand, connection);

                metroGrid1.Refresh();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcommand, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                metroGrid1.DataSource = dataTable;
                connection.Close();


            }

        }



    }
}

