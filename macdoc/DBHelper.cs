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
using Guna.UI2.WinForms;
using System.Windows.Controls;
using System.Reflection.Emit;
using System.Web.UI.WebControls;

namespace macdoc
{
    public class DBHelper
    {

        public static string Users = "users";
        public static string Machine = "machine";
        public static string Staff_activity = "staff_activity";
        public static string Files = "files";
        public static string SelectedMachine;

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
                               " count(id_machine) as counts from component inner join machine on id_machine =" +
                                "machine.id  where machine.nom = '" + selected_machine + "' and component.type = '"+selected_component+"'; ";

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
                            
                            

                        string sql = "insert into component  (nom,reference,date_insertion,date_modification,id_machine,life_duration,type,modificateur) values('"
                                                        + name + "','" + reference + "','"
                                                        + date_ins + "','"
                                                        + date_modif + "','" + id + "','"
                                                        + duration + "','"
                                                        + component + "'," +
                                                        "1);";

                                    SQLiteCommand command = new SQLiteCommand(sql, conn);


                                    if (command.ExecuteNonQuery() > 0)
                                    {

                                        conn.Close();

                                        done = true;



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

                            string updateSql = "update  component set nom = '" + name + "'" +
                                 ",reference = '" + reference + "',date_insertion = '" + date_ins +
                                 "',date_modification = '" + date_modif + "' , num_modification = num_modification + 1 " +
                                 "where id = " + id + " and type = '" + component + "';";

                            SQLiteCommand command = new SQLiteCommand(updateSql, conn);


                            if (command.ExecuteNonQuery() > 0)
                            {
                                string id_machine = new SQLiteCommand("select id_machine from component where reference = '"+reference+"';", conn).ExecuteScalar().ToString();


                                string insertSql = "insert into modification (date,id_composant,modificateur,notes,id_machine)" +
                                    " values ('"+date_modif+"', "+id+","+ modificateur+",'"+notes+"',"+id_machine+");";
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

        public static void FillAddMachineComponentGrid(string component,DataTable dataTable,MetroGrid Compos,string machineID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"]
                 .ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        string sql = "select nom , reference , date_insertion as \"date d'insertion\", "
                            + "date_modification as \" derniére modification\" ," +
                "life_duration as \"durée de vie\" , num_modification as \"nombre de modification\" from  component  where id_machine = " + machineID + " and type = '"+component+"';";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Compos.Refresh();

                        Compos.DataSource = dataTable;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception " + ex.Message);

                    }
                    conn.Close();

                }
                else
                {


                    conn.Close();


                }

            }
        }
        public static void FillHomeGrid(MetroGrid metroGrid1,string selection,string selected_machine)
        {

            string sqlcommand = "select component.id, component.nom , component.reference , date_insertion as \"date d'insertion\", date_modification as \"date " +
                    "de modification\" , life_duration as \"durée de vie\" , num_modification as \"nombre de modifications \"  from" +
                    " component inner join machine on machine.id = component.id_machine where machine.nom = '" 
                    + selected_machine + "' and component.type ='"+selection+"';";

            if (Equals(selection, "Vérin"))
            {

                selection = "verin";
                sqlcommand = "select nom , reference , dernier_vidange as \"dernier vidange\" , huil_durée as \"huile longevité\" from verin inner join component on verin.id_component = " +
                    "component.id where component.type = 'verin';";

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

        public static void FillArchiveModifications(MetroGrid machineGrid,string orderBy,
            string id_machine,string ComponentType,string user,string limit)
        {
            bool withUsers = false ;

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        string sql = "";

                            switch (ComponentType)
                            {
                                case "Capteurs":
                                    ComponentType = "Capteur";
                                    break;
                                case "Moteurs":
                                    ComponentType = "Moteur";

                                    break;
                                case "Reducteur":
                                    ComponentType= "Reducteur";

                                    break;
                                case "Vérins":
                                    ComponentType = "Verin";

                                    break;
                                case "Courroies":
                                    ComponentType = "Courroie";

                                    break;
                                case "Tout":
                                    ComponentType = "Tout";

                                
                                    break;
                            }

                            

                        if (!Equals(id_machine, "")&&!Equals(ComponentType, "Tout"))
                        {
                            if(user != "Tout")
                            {
                                withUsers = true;

                        
                            }
                            else
                            {
                                withUsers = false;

                            }
                            if (withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, " +
                                    "component.reference, users.nom as modificateur ," +
                                                        " date_modification as \"derniére modification\" , " +
                                                        "notes from modification inner join component" +
                                 " on modification.id_composant = component.id  inner join users " +
                                            "on users.id = modification.modificateur inner join machine on machine.id = component.id_machine  " +
                                                    " where component.type = '" + ComponentType + "' and component.id_machine = "
                                                    + id_machine + " and users.nom = '" + user + "' order by component.type," + orderBy + " limit " + limit + " ;";

                            }
                            else if(!withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, " +
                                    "component.reference, users.nom as modificateur ," +
                                                        " date_modification as \"derniére modification\" , " +
                                                        "notes from modification inner join component" +
                                 " on modification.id_composant = component.id  inner join users " +
                                            "on users.id = modification.modificateur inner join machine on machine.id = component.id_machine  " +
                                                    " where component.type = '" + ComponentType + "' and component.id_machine = "
                                                    + id_machine + "  order by component.type," + orderBy + " limit "+ limit +" ;";
                            }
                            else if (!withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, " +
                                    "component.reference, users.nom as modificateur ," +
                                                        " date_modification as \"derniére modification\" , " +
                                                        "notes from modification inner join component" +
                                 " on modification.id_composant = component.id  inner join users " +
                                            "on users.id = modification.modificateur inner join machine on machine.id = component.id_machine  " +
                                                    " where component.type = '" + ComponentType + "' and component.id_machine = "
                                                    + id_machine + "  order by component.type," + orderBy + " ;";
                            }
                            else if (withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, " +
                                   "component.reference, users.nom as modificateur ," +
                                                       " date_modification as \"derniére modification\" , " +
                                                       "notes from modification inner join component" +
                                " on modification.id_composant = component.id  inner join users " +
                                           "on users.id = modification.modificateur inner join machine on machine.id = component.id_machine  " +
                                                   " where component.type = '" + ComponentType + "' and component.id_machine = "
                                                   + id_machine + "  and users.nom = '" + user +"'  order by component.type," + orderBy +" ;";
                            }



                        }
                        else if(Equals(id_machine,"")&& !Equals(ComponentType, "Tout")){


                            if (user != "Tout")
                            {
                                withUsers = true;

                   

                            }
                            else
                            {
                                withUsers = false;

                             
                            }
                            if (withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, users.nom as modificateur ," +
                         " date_modification as \"derniére modification\" , notes from modification inner join component" +
                     " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur  inner join machine on machine.id = component.id_machine" +
                     " where component.type = '" + ComponentType + "' and users.nom = '" + user + "'  order by component.type," + orderBy + " limit "+limit+";";

                            }
                            else if (!withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, " +
                                    "users.nom as modificateur ," +
                                            " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                            " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur" +
                                            "  inner join machine on machine.id = component.id_machine" +
                                            " where component.type = '" + ComponentType + "'  order by component.type," + orderBy + " limit " + limit
                                            + " ;";
                            }
                            else if (!withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, " +
                                    "users.nom as modificateur ," +
                                            " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                            " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur" +
                                            "  inner join machine on machine.id = component.id_machine" +
                                            " where component.type = '" + ComponentType + "'  order by component.type," + orderBy +" ;";
                            }
                            else if (withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, " +
                                     "users.nom as modificateur ," +
                                             " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                             " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur" +
                                             "  inner join machine on machine.id = component.id_machine" +
                                             " where component.type = '" + ComponentType + "'  and users.nom = '" + user + "'  order by component.type," + orderBy +" ;";
                            }



                        }
                        else if(Equals(id_machine, "") && Equals(ComponentType, "Tout"))
                        {
                            if (user != "Tout")
                            {
                                withUsers = true;

                        
                            }
                            else
                            {
                                withUsers = false;


                            }
                            if (withUsers && limit != "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom," +
                                    " component.reference, users.nom as modificateur ," +
                                " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                    " on modification.id_composant = component.id  inner join users on" +
                                    " users.id = modification.modificateur  inner join machine on machine.id = " +
                                    "component.id_machine where users.nom = '"+user+"' order by component.type, " + orderBy + " limit "+limit+" ;";

                            }
                            else if (!withUsers && limit != "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom," +
                                    " component.reference, users.nom as modificateur ," +
                                " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                    " on modification.id_composant = component.id  inner join users on" +
                                    " users.id = modification.modificateur  inner join machine on machine.id = " +
                                    "component.id_machine order by component.type, " + orderBy + " limit "+limit+";";
                            }
                            else if (!withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom," +
                                    " component.reference, users.nom as modificateur ," +
                                " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                    " on modification.id_composant = component.id  inner join users on" +
                                    " users.id = modification.modificateur  inner join machine on machine.id = " +
                                    "component.id_machine order by component.type, " + orderBy + ";";
                            }
                            else if (withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom," +
                                    " component.reference, users.nom as modificateur ," +
                                " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                    " on modification.id_composant = component.id  inner join users on" +
                                    " users.id = modification.modificateur  inner join machine on machine.id = " +
                                    "component.id_machine where users.nom = '" + user + "' order by component.type, " + orderBy + ";";
                            }
                        }
                        else if (!Equals(id_machine, "") && Equals(ComponentType, "Tout"))
                        {


                            if (user != "Tout")
                            {
                                withUsers = true;


                            }
                            else
                            {
                                withUsers = false;

                            }
                            if (withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, users.nom as modificateur ," +
                            " date_modification as \"derniére modification\" , notes from modification inner join component" +
                        " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur inner join machine on machine.id = component.id_machine " +
                        "  where component.id_machine = " + id_machine + " and users.nom ='"+user+"' order by component.type," + orderBy + " limit "+limit+" ;";

                            }
                            else if (!withUsers && limit != "Tout")
                            {
                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, users.nom as modificateur ," +
                                                     " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                                 " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur inner join machine on machine.id = component.id_machine " +
                                                 "  where component.id_machine = " + id_machine + " order by component.type," + orderBy + " limit "+limit+" ;";
                            }
                            else if (!withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, users.nom as modificateur ," +
                                                    " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                                " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur inner join machine on machine.id = component.id_machine " +
                                                "  where component.id_machine = " + id_machine + " order by component.type," + orderBy + ";";
                            }
                            else if (withUsers && limit == "Tout")
                            {

                                sql = "select machine.nom as machine , component.type , component.nom as nom, component.reference, users.nom as modificateur ," +
                                                     " date_modification as \"derniére modification\" , notes from modification inner join component" +
                                                 " on modification.id_composant = component.id  inner join users on users.id = modification.modificateur inner join machine on machine.id = component.id_machine " +
                                                 "  where component.id_machine = " + id_machine + "  and users.nom ='"+user+"' order by component.type," + orderBy + "  ;";
                            }


                        }


                        


                        conn.Open();

                        SQLiteCommand command = new SQLiteCommand(sql, conn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        machineGrid.DataSource = table;

                }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Couldn't select component id !"+ex.Message, "", MessageBoxButtons.OK);

                    }
                    conn.Close();

                }
                else
                {


                    conn.Close();


                }

            }

        }
        public static void FillMachines(int machine,string type , Guna2ComboBox machineCombo)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        string sql = "select nom from machine where type = '" + type + "';";
                        SQLiteCommand command = new SQLiteCommand(sql, conn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        SQLiteDataReader data = command.ExecuteReader();

                        machineCombo.Items.Clear();

                        while (data.Read())
                        {
                            machineCombo.Items.Add(data.GetValue(0));
                        }
                        machineCombo.SelectedIndex = 0;

                    }
                    catch
                    {
                        Form ajout = new AjouterMachine("", machine, false);
                        ajout.Text = "Ajouter votre premiere machine de " + type;
                        ajout.ShowDialog();


                    }
                    conn.Close();

                }
                else
                {


                    conn.Close();


                }

                

            }

        }
        public static string InsertMachine(string machine ,string SelectedType ,string reference,
            string date,string component)
        {

            bool added = false;
            string machineID = "0";
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {


                        if (!(Equals(machine, "") || Equals(SelectedType, null)))
                        {
                            string sql = "insert into machine (nom,type,reference,date_installation) values('" + machine + "','" + SelectedType.Trim() + "','" + reference + "','" + date + "');";
                            string idQ = "select id from machine where nom = '" + machine + "';";

                            SQLiteCommand command = new SQLiteCommand(sql, conn);
                            SQLiteCommand id_comm = new SQLiteCommand(idQ, conn);



                            if (command.ExecuteNonQuery() > 0)
                            {
                                added = true;
                                MessageBox.Show("La machine a été ajoutée avec succès", "Ajout", MessageBoxButtons.OK);


                            }
                            else
                            {
                                MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                            }
                            machineID = id_comm.ExecuteScalar().ToString();


                        }
                        else
                        {
                            MessageBox.Show("Le nom et le type sont obligatoires", "Ajout", MessageBoxButtons.OK);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.ToLower().Contains("unique"))
                        {
                            MessageBox.Show("Echec ! Un " + component + " avec le meme reference s'existe déjà", "Ajout", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("Echec ! ", "Echec d'ajouter une machine", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }
                }
                else
                {


                    conn.Close();


                }

                return machineID;


            }

        }
        public static void FillModifGrid(Machine machine, string component,MetroGrid Compos,DataTable dataTable,RoundedLabel CompNum)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"]
                .ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        string sql = "select component.nom , component.reference ,component.date_insertion as \"date d'insertion\", component.date_modification as \" derniére modification\" ," +
                 "component.life_duration as \"durée de vie\" , num_modification as \"nombre de modification\" from component where component.id_machine = " + machine.ID + " and type ='" + component+ "' ;";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Compos.Refresh();

                        Compos.DataSource = dataTable;
                        CompNum.Text = Compos.RowCount.ToString();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception " + ex.Message);

                    }
                    conn.Close();

                }
                else
                {


                    conn.Close();


                }

            }
        }

        public static void SelectAllUsers(Guna2ComboBox users)
        {

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                conn.Open();

                string command = "select nom from users ;";

                SQLiteCommand sQLiteCommand = new SQLiteCommand(command, conn);

                SQLiteDataReader reader = sQLiteCommand.ExecuteReader();
                users.Items.Clear();

                users.Items.Add("Tout");

                while (reader.Read())
                {
                    users.Items.Add(reader.GetString(0));

                }

                conn.Close();


            }
        }
    }
}

