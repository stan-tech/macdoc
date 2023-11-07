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
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System.Collections;
using System.Web.Services.Description;
using FontAwesome.Sharp;

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
                                "machine.id  where machine.nom = '" + selected_machine + "' and component.type = '"+selected_component+"' and inserted =1; ";

                    SQLiteCommand cmd = new SQLiteCommand(composants_num, connection);

                    compnum = cmd.ExecuteScalar().ToString();

                    connection.Close();

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
                            
                            

                        string sql = "insert into component  (nom,reference,date_insertion,date_modification,id_machine,life_duration,type,modificateur,inserted,replaced) values('"
                                                        + name + "','" + reference + "','"
                                                        + date_ins + "','"
                                                        + date_modif + "'," + id + ",'"
                                                        + duration + "','"
                                                        + component + "'," +
                                                        "1,1,0);";
                            string updateStore = "update  component_store set "
                                         + " quantity_left = quantity_left + 1" +
                                          " where type = '" + component + "' and state = \"InUse\";";

                            SQLiteCommand storeCommand = new SQLiteCommand(updateStore, conn)
                                , command = new SQLiteCommand(sql, conn);


                                    if (command.ExecuteNonQuery() > 0)
                                    {

                                        if (storeCommand.ExecuteNonQuery()>0)
                                        {

                                            done = true;
        
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
                    finally
                    {
                        conn.Close();

                    }
                }
                else
                {


                    conn.Close();


                }




            }

            return done;
        }

        public static bool PerformModification(string id, string Oldcomponent,string NewComponent, string name, string reference, string date_ins,
            string date_modif, string notes,string modificateur,bool replaced,string type)
        {
            bool done = false;
            bool keepGoing = true;

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
                                 "where id = " + id + ";";
                            string updateNewSql,updateStore,updateStoreMinus = "";

                            if (replaced)
                            {
                                updateSql = "update  component set nom = '" + name + "'" +
                                 ",inserted = 0 , replaced = 1, date_insertion = '" + date_ins +
                                 "',date_modification = '" + date_modif + "' , num_modification = num_modification + 1 " +
                                 "where reference = '" + Oldcomponent + "';";

                                updateStore = "update  component_store set "  
                                          + " quantity_left = quantity_left + 1" +
                                           " where type = '" + type + "' and state = \"Replaced\";";

                                updateStoreMinus = "update  component_store set "
                                          + " quantity_left = quantity_left - 1" +
                                           ", total =  quantity_left * price_ where type = '" + type + "' and state = \"Nouveau\";";

                                SQLiteCommand updateCommand = new SQLiteCommand(updateStore, conn);
                                SQLiteCommand updateCommandMinus = new SQLiteCommand(updateStoreMinus, conn);


                                try
                                {
                                    if(updateCommand.ExecuteNonQuery() <=0 ||
                                        updateCommandMinus.ExecuteNonQuery() <= 0)
                                    {
                                        keepGoing = false;
                                        MessageBox.Show("Quelque chose n'est pas correcte!");
                                    }
                                }
                                catch(Exception ex)
                                { 
                                
                                
                                
                                }



                            }

                            if (keepGoing)
                            {
                                using (SQLiteCommand command = new SQLiteCommand(updateSql, conn))
                                {

                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        string id_machine = new SQLiteCommand("select id_machine from component where reference = '" + Oldcomponent + "';", conn)
                                            .ExecuteScalar().ToString();

                                        if (id_machine.Equals(""))
                                        {
                                            id_machine = "null";
                                        }

                                        if (replaced)
                                        {
                                            updateNewSql = "update  component set nom = '" + name + "'" +
                                           ",inserted = 1 ,replaced = 0, id_machine = " + id_machine + ",date_insertion = '" + date_ins +
                                           "',date_modification = '" + date_modif + "' " +
                                           "where reference = '" + NewComponent + "';";

                                            SQLiteCommand Newcommand = new SQLiteCommand(updateNewSql, conn);
                                            try
                                            {
                                                Newcommand.ExecuteNonQuery();

                                            }
                                            catch (Exception)
                                            {

                                                throw;
                                            }

                                        }


                                        string insertSql = "insert into modification (date,id_composant,modificateur,notes,id_machine)" +
                                            " values ('" + date_modif + "', " + id + "," + modificateur + ",\"" + notes + "\"," + id_machine + ");";
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

                            }

                           

                        }
                        else
                        {

                            MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                        }




                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show("Echec ! " + ex.Message, " Echec de modifier le composant", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    finally
                    {
                        conn.Close();

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
                    + selected_machine + "' and component.type ='"+selection+"' and inserted = 1;";

            if (Equals(selection, "Vérin"))
            {

                selection = "verin";
                sqlcommand = "select nom , reference , dernier_vidange as \"dernier vidange\" , huile_durée as \"huile longevité\" from verin inner join component on verin.id_component = " +
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

        public static async Task<DataTable > FillArchiveModifications(string orderBy,
            string id_machine,string ComponentType,string user,string limit)
        {
            bool withUsers = false ;
            DataTable table = new DataTable();

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

                        adapter.Fill(table);


                }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Couldn't select component id !"+ex.Message, "", MessageBoxButtons.OK);

                    }
                    finally{
                        conn.Close();

                    }

                }
                else
                {


                    conn.Close();


                }

            }

            return table;
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
                    finally
                    {
                        conn.Close();

                    }

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


        public static User ReturnUser(string name, string password)
        {
            User user = null;
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string user_to_return = "select nom , prenom , telephone, password from users where nom = '" + name + "' and password = '" + password + "' ;";

                    SQLiteCommand sQLiteCommand = new SQLiteCommand(user_to_return, conn);
                    SQLiteDataReader reader = sQLiteCommand.ExecuteReader();




                    if (reader.Read())
                    {
                        user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        user.PassWord = reader.GetString(3);

                    }
                    reader.Close();
                    conn.Close() ;
                }
                else
                {
                    conn.Close();
                }
                

            }

            return user;
        }
        public static void SelectAllUsers(Guna2ComboBox users)
        {

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                conn.Open();

                string command = "select nom from users ;";


                SQLiteCommand sQLiteCommand = new SQLiteCommand(command, conn);


                SQLiteDataReader reader = sQLiteCommand.ExecuteReader();

                users.Invoke((MethodInvoker)(() => users.Items.Clear()));

                users.Invoke((MethodInvoker)(() => users.Items.Add("Tout")));

                while (reader.Read())
                {
                    users.Invoke((MethodInvoker)( () =>  users.Items.Add(reader.GetString(0))

                        ));

                }

                users.Invoke((MethodInvoker)(() => users.SelectedIndex=0));

                reader.Close();

                conn.Close();


            }
        }
        public static User SelectAdmin()
        {
            User user = null;

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();


                    string selectAdmin = "select id,nom,prenom,telephone,role,password from users where role = 'Admin'";

                    SQLiteCommand command = new SQLiteCommand(selectAdmin,conn);
                    SQLiteDataReader reader = command.ExecuteReader();

                    if(reader.Read()) {

                        user = new User(reader.GetString(1),reader.GetString(2),reader.GetString(3));

                    }
                    reader.Close();

                    conn.Close();
                }
                else
                {
                    conn.Close();
                }
            }

            return user;
        }


      

        public static async Task<DataTable> FillStoreGrid(string state)
        {
            DataTable table = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();


                    string selectAdmin = "select type as Composant , quantity_left as \"Reste\"  , price_ as Prix , unit as Unité  , Price_*quantity_left as Total from component_store where state = '" + state + "';";

                    try
                    {
                        SQLiteCommand command = new SQLiteCommand(selectAdmin, conn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(table);




                    }
                    catch (Exception e)
                    {
                        string i = e.Message;
                        
                    }

                }
                else
                {
                    conn.Close();
                }
                
            }
            return table;
            
        }
        public static Dictionary<string, int> AssignQuantity(List<Component> list)
        {
        
            int assigned_qt= 0;
            int qtCap = 0, qtRed = 0, qtMot = 0, qtCourr = 0, qtHuile = 0;

            Dictionary<string, int> quantities = new Dictionary<string, int>();
            
            foreach (Component c in list)
            {
                switch (c.Type)
                {
                    case "Capteur":
                        qtCap += c.Quantity;
                     
                        assigned_qt = qtCap;

                        break;
                    case "Moteur":
                        qtMot += c.Quantity;
                        assigned_qt = qtMot;


                        break;
                    case "Reducteur":
                        qtRed += c.Quantity;
                        assigned_qt = qtRed;

                        break;
                    case "Huile":
                        qtHuile += c.Quantity;
                        assigned_qt = qtHuile;

                        break;
                    case "Courroie":
                        qtCourr += c.Quantity;
                        assigned_qt = qtCourr;

                        break;
                }
            }

            quantities.Add("Capteur", qtCap);
            quantities.Add("Moteur", qtMot);

            quantities.Add("Reducteur", qtRed);

            quantities.Add("Huile", qtHuile);
            quantities.Add("Courroie", qtCourr);

            return quantities;



        }
        public static bool AddToStore(List<Component> components,Dictionary<string,double> prices)
        {
            bool done = false;
           
            Dictionary<string, int> AssignedQuantity = AssignQuantity(components);
            string[] types = new string[AssignedQuantity.Keys.Count];

            string insertComponent = "";
            string updatestorePrice = "", updatestore = "";


            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        
                        AssignedQuantity.Keys.CopyTo(types, 0);


                       

                            foreach (Component component in components)
                             {

                                        insertComponent = "insert into component (nom,reference,prix,date_insertion,date_modification," +
                                                                "life_duration,num_modification,inserted,type) values('" + component.Name + "','" + component.Reference + "'," + component.Price
                                                                + ",'" + component.Date_insertion + "','" + component.Date_modification + "','" + component.Life_duration + "'," + component.Num_modifications
                                                                + "," + 0 + ",'" + component.Type + "');";

                                    SQLiteCommand command = new SQLiteCommand(insertComponent, conn);

                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                      
                                            done = true;

                                                                             

                                    }
                                    else
                                    {
                                        done = false;

                                    }
                                }

                            for (int a = 0; a < types.Length; a++)
                            {

                                if (AssignedQuantity[types[a]] != 0)
                                {
                                    updatestore = "update  component_store set price_ = " + prices[types[a]]
                                           + " , quantity_left = quantity_left + " + AssignedQuantity[types[a]]+
                                            " where type = '" + types[a] + "' and state = \"Nouveau\";";


                                updatestorePrice = "update  component_store set price_ = " + prices[types[a]]
                                          + " where type = '" + types[a] + "';";

                                SQLiteCommand updateCommand = new SQLiteCommand(updatestore, conn);
                                SQLiteCommand updatePriceCommand = new SQLiteCommand(updatestorePrice, conn);


                                if (updateCommand.ExecuteNonQuery() > 0 &&
                                    updatePriceCommand.ExecuteNonQuery()>0)
                                    {
                                        done = true;

                                    }
                                    else
                                    {
                                        done = false;
                                    }

                                }

                            }

                            

                    }catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    conn.Close();
                }
            }
            return done;
                  
        }

        public static AutoCompleteStringCollection SelectAvailableReferences(Component component)
        {

            AutoCompleteStringCollection refs = new AutoCompleteStringCollection();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string command = "select reference from component where inserted = 0 and replaced = 0 and type = '"+component.Type+"';";
                    int i = 0;

                    SQLiteCommand sqlcmd = new SQLiteCommand (command, conn);
                        
                    try
                    {
                        SQLiteDataReader dataReader = sqlcmd.ExecuteReader();
                      
                        
                        while (dataReader.Read())
                        {

                            refs.Add(dataReader.GetString(0));
                        }

                        dataReader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Quelque chose n'est pas correcte! "+ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }


                    return refs;
        }
        public static async Task<DataTable> SelectStoreComponents(MetroGrid grid , string selectionType, bool search, string searchText)
        {
            string condition = "";

            switch (selectionType)
            {
                case "n":
                    condition = "inserted = 0 and replaced = 0";

                    break;
                case "u":
                    condition = "inserted = 1";

                    break;
                case "r":
                    condition = "inserted = 0 and replaced = 1";

                    break;
            }

            DataTable table = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                string select;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                    if (search && !searchText.Equals(""))
                    {

                       select  = "select component.id,component.Type as Type, component.nom , component.reference , date_insertion as \"date d'insertion\", date_modification as \"date " +
                                          "de modification\" , life_duration as \"durée de vie\", machine.nom as Machine from" +
                                          " component full join machine on machine.id = component.id_machine where " +
                                          "( LOWER(component.reference) like '%" + searchText.ToLower().Trim()+ "%' or LOWER(component.nom) " +
                                          "like '%" + searchText.ToLower().Trim()+ "%' ) and " + condition + "  order by component.id, component.Type ; ";
                    }
                    else
                    {

                         select = "select component.id,component.Type as Type, component.nom , component.reference , date_insertion as \"date d'insertion\", date_modification as \"date " +
                                          "de modification\" , life_duration as \"durée de vie\", machine.nom as Machine from" +
                                          " component full join machine on machine.id = component.id_machine where " + condition + " order by component.id, component.Type;";

                    }
                    SQLiteCommand sqlcmd = new SQLiteCommand(select, conn);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcmd);
                    try
                    {
                        adapter.Fill(table);
                        grid.Invoke((MethodInvoker)(() => {
                            grid.DataSource = table;
                        }));

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return table;
        }
        public static void SelectNumber(IconButton newComponent, IconButton UsedComponent, IconButton ReplacedComponent)
        {

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                string selectUsed = "select count(id) from  component where inserted =1;";
                string selectNew= "select count(id) from  component where inserted = 0 and replaced = 0;";

                string selectReplaced = "select count(id) from  component where inserted =0 and replaced =1;";




                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                    try
                    {
                        SQLiteDataReader reader = new SQLiteCommand(selectNew, conn).ExecuteReader();
                        SQLiteDataReader Usedreader = new SQLiteCommand(selectUsed, conn).ExecuteReader();

                        SQLiteDataReader Replacedreader = new SQLiteCommand(selectReplaced, conn).ExecuteReader();

                      UsedComponent.Invoke((MethodInvoker) (()=> {


                          if (Usedreader.Read())
                          {
                              UsedComponent.Text = "En usage" + "       " + Usedreader.GetInt32(0);

                          }
                      }));
                        ReplacedComponent.Invoke((MethodInvoker)(() =>
                        {
                            if (Replacedreader.Read())
                            {
                                ReplacedComponent.Text = "Remplacés" + "        " + Replacedreader.GetInt32(0);

                            }                        }));

                        newComponent.Invoke((MethodInvoker)(() =>
                        {
                            if (reader.Read())
                            {
                                newComponent.Text = "Nouveaux" + "       " + reader.GetInt32(0);

                            }                        }));

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }




                }
            }
        }
        public static void SelectFromComponentStore(RoundedGrid roundedGrid, string state)
        {
            DataTable table = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();


                    string selectAdmin = "select type as Composant , quantity_left as \"Reste\"  , price_ as Prix , unit as Unité  , Total from component_store where state = '"+state+"';";

                    try
                    {
                        SQLiteCommand command = new SQLiteCommand(selectAdmin, conn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(table);


                        roundedGrid.Invoke((MethodInvoker)(() =>
                        {
                            
                                roundedGrid.DataSource = table;

                            
                        }));



                    }
                    catch (Exception e)
                    {
                        string i = e.Message;

                    }

                }
                else
                {
                    conn.Close();
                }

            }
        }

    }
}

