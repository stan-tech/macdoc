using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Windows.Media.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.ComponentModel;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.IO;
using DevExpress.XtraEditors.Filtering.Templates;

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

        public static bool InsertComponent(string id,string component,string name,string reference, string date_ins, 
            string date_modif,string duration)
        {
            bool done = false;


            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                       

                        if (!(Equals(name, "") || Equals(reference, "")))
                        {
                            
                            string component_insert = "insert into component (type) values('" + component + "')";
                            
                            SQLiteCommand compoCommand = new SQLiteCommand(component_insert, conn);

                            if (compoCommand.ExecuteNonQuery() > 0)
                            {
                                string lastComponentID = new SQLiteCommand("select max(id) from component;", conn).ExecuteScalar().ToString();

                                if (!Equals(lastComponentID,""))
                                {
                                    string sql = "insert into " + component + " (nom,reference,date_insertion,date_modification,id_machine,life_duration,id_composant) values('"
                                                                                            + name + "','" + reference + "','"
                                                                                            + date_ins + "','"
                                                                                            + date_modif + "','" + id + "','" + duration + "'," + lastComponentID + ");";

                                    SQLiteCommand command = new SQLiteCommand(sql, conn);


                                    if (command.ExecuteNonQuery() > 0)
                                    {

                                        conn.Close();

                                        done = true;



                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);

                                }
                            }
    
                         

                        }
                        else
                        {

                            MessageBox.Show("Veuillez remplisser les champs  !", "Ajout", MessageBoxButtons.OK);


                        }




                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.ToLower().Contains("unique"))
                        {
                            MessageBox.Show("Echec ! Un " + component + " avec le meme reference s'existe déjà", "Ajout", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("Echec ! ", "Echec d'ajouter un " + component, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }
                }
                else
                {


                    conn.Close();


                }




            }

            return done;
        }

        public static bool PerformModification(string id, string component, string name, string reference, string date_ins,
            string date_modif, string notes,string modificateur)
        {
            bool done = false;

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
               


                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {

                        if (!(Equals(name, "") || Equals(reference, "")))
                        {

                           string  updateSql = "update  " + component + " set nom = '" + name + "'" +
                                ",reference = '" + reference + "',date_insertion = '" +date_ins +
                                "',date_modification = '" + date_modif + "' , num_modification = num_modification + 1 " +
                                "where id = " +id + ";";

                            string id_composant = "";
                            SQLiteCommand id_composantQuery = new SQLiteCommand("select id_composant from " + component +
                                                        " where reference = '" + reference + "';", conn);

                            try
                            {

                               id_composant =  id_composantQuery.ExecuteScalar().ToString();
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Couldn't select component id !", "", MessageBoxButtons.OK);
                            }

                            SQLiteCommand command = new SQLiteCommand(updateSql, conn);


                            if (command.ExecuteNonQuery() > 0)
                            {

                                string insertSql = "insert into modification (date,id_composant,modificateur,notes)" +
                                    " values ('"+date_modif+"', "+id_composant+","+ modificateur+",'"+notes+"');";
                                SQLiteCommand cmd = new SQLiteCommand(insertSql, conn);


                                if (cmd.ExecuteNonQuery() > 0)
                                {

                                    done = true;
                                }


                                conn.Close();



                            }
                            else
                            {
                                MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                            }

                        }
                        else
                        {

                            MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                        }




                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show("Echec ! " + ex.Message, "Echec d'ajouter un composant", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                else
                {


                    conn.Close();


                }




            }





            return done;
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

