using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube;

namespace macdoc
{
    public partial class AjouterMachine : Form
    {
        int type;
        private string SelectedType;
       public static string last_id="0";
        bool empty = false;
        public bool Added ;
        public bool refresh = false ;
        public static string component;
        public static string machine = "";
        public static DataTable dataTable = new DataTable();

        public AjouterMachine(string component,int type,bool added)
        {
            InitializeComponent();
            this.type = type;
            Added = added;

            if(refresh)
            FillGrid(component);


        }

        public bool Refresh
        {
            get { return refresh; }
            set { refresh = value; }
        }
        private void ComponentName_TextChanged(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            TypeCom.Click += new System.EventHandler(this.TypeCom_Click);


           


        }

        public  void Ajouter_composant_FormClosed(object sender, FormClosedEventArgs e)
        {

            Task.Run(() => {

               FillGrid(component);

            });

            
        }

        private static void FillTable(DataTable dataTable)
        {


            throw new NotImplementedException();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            machine = MacName.Text;


            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {


                        if (!(Equals(MacName.Text,"")||Equals(SelectedType,null)))
                        {
                            string sql = "insert into machine (nom,type,reference,date_installation) values('" + machine + "','" + SelectedType.Trim() + "','"+Ref.Text+"','" + datepicker.Value.ToString() + "');";
                            string idQ =  "select id from machine where nom = '" + machine + "';";
                            
                            SQLiteCommand command = new SQLiteCommand(sql, conn);
                            SQLiteCommand id_comm = new SQLiteCommand(idQ, conn);
                            


                            if (command.ExecuteNonQuery() > 0)
                            {
                                empty = false;
                                Added = true;
                                MessageBox.Show("La machine a été ajoutée avec succès", "Ajout", MessageBoxButtons.OK);
                                

                            }
                            else
                            {
                                MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                            }
                            last_id = id_comm.ExecuteScalar().ToString();


                        }
                        else
                        {
                            MessageBox.Show("Le nom et le type sont obligatoires", "Ajout", MessageBoxButtons.OK);
                        }
                        conn.Close();

                    }
                    catch(Exception ex)
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

             


            }

        }

        private void TypeCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if(TypeCom.SelectedItem != null)
                {
                    SelectedType = TypeCom.SelectedItem.ToString();

                }
                else
                {
                    SelectedType = "";

                }
      
        }

        private void TypeCom_Click(object sender, EventArgs e)
        {
            TypeCom.Select();
        }

        /*
         Techno-ferrari
Banc
   Triage
   New-check
CPK
Accoppiatre
    Extra-pack
    Maxi
         
         */

        public void AjouterMachine_Shown(object sender, EventArgs e)
        {
            switch (type)
            {
             
                case 0:

                    TypeCom.SelectedIndex = 0;
                    break;
                case 2:
                    TypeCom.SelectedIndex = 2;
                    break;
                case 1:
                    TypeCom.SelectedIndex = 1;
                    break;

                case 3:
                    TypeCom.SelectedIndex = 3;
                    break;
                case 4:

                    TypeCom.SelectedIndex = 4;
                    break;
                case 5:
                    TypeCom.SelectedIndex = 5;
                    
                    break;
                case 6:

                    TypeCom.SelectedIndex = 6;
                    break;
           
                case 7:
                    TypeCom.SelectedIndex = 7;
                    break;
         
                
            }


            CompNum.Text = Compos.RowCount.ToString();

            caps.SelectedIndex = 0;
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
        }

        //private void TypeCom_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0) return;
        //    Font f = TypeCom.Font;
        //    int yOffset = 50;

        //    if ((e.State & DrawItemState.Focus) == 0)
        //    {
        //        e.Graphics.FillRectangle(Brushes.White, e.Bounds);
        //        e.Graphics.DrawString(TypeCom.Items[e.Index].ToString(), f, Brushes.Black,
        //                              new Point(e.Bounds.X, e.Bounds.Y + yOffset));
        //    }
        //    else
        //    {
        //        e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
        //        e.Graphics.DrawString(TypeCom.Items[e.Index].ToString(), f, Brushes.White,
        //                              new Point(e.Bounds.X, e.Bounds.Y + yOffset));
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void AjouterMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i = 0;
            int[] count = new int[6];


            if (Added)
            {
                try
                {
                    using (SQLiteConnection connection =
                        new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand("select count(capteur.id) AS cap , count(moteur.id) as mot," +
                            "count(verin.id) as ver,count(courroie.id) as courr,count(reducteur.id) as reduc " +
                            "from capteur  full join verin on  capteur.id_machine= verin.id_machine" +
                            " full join moteur on capteur.id_machine = moteur.id_machine full join courroie on " +
                            "capteur.id_machine = courroie.id_machine full join reducteur on reducteur.id_machine =" +
                            " capteur.id_machine where capteur.id_machine = " + last_id + " or courroie.id_machine = " + last_id + " or moteur.id_machine = " + last_id +
                            " or reducteur.id_machine = " + last_id + " or verin.id_machine = " + last_id + ";", connection);

                        SQLiteDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int x = reader.GetInt32(3);

                            while (i < reader.FieldCount)
                            {
                                if (reader.GetInt32(i) > 0)
                                {
                                    count[i] = reader.GetInt32(i);
                                    empty = true;
                                    break;
                                }
                                i++;

                            }

                        }
                    }

                }
                catch (Exception eX)


                {

                    MessageBox.Show(eX.Message);
                }
                if (!empty)
                {
                    DialogResult dialog = MessageBox.Show("Quitter sans ajouter un composants ?"
                        , "Ajouter des composants", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {

                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }
                else
                {
                    e.Cancel = false;

                }

                return;
            }
            e.Cancel = false;
           

        }


        public  void RefreshRequest(object sender, EventArgs e)
        {
            FillGrid(component);
            CompNum.Text = Compos.RowCount.ToString();

        }
        private void Ajout_button_Click(object sender, EventArgs e)
        {
            component = "Capteur";

            Ajouter_composant ajout = new Ajouter_composant(component, last_id);

            ajout.RefreshRequest += RefreshRequest; 


            ajout.ShowDialog();

        }

        private void Ajoumot_Click(object sender, EventArgs e)
        {
            component = "Moteur";

            Ajouter_composant ajout = new Ajouter_composant(component, last_id);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void Ajoured_Click(object sender, EventArgs e)
        {
            component = "Reducteur";

            Ajouter_composant ajout = new Ajouter_composant(component, last_id);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void ajouver_Click(object sender, EventArgs e)
        {
            component = "Verin";

            Ajouter_composant ajout = new Ajouter_composant(component, last_id);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void AjouCour_Click(object sender, EventArgs e)
        {
            component = "Courroie";

            Ajouter_composant ajout = new Ajouter_composant(component, last_id);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillGrid(string component)
        {

            if (Added)
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
                    "life_duration as \"durée de vie\" , num_modification as \"nombre de modification\" from " + component + " where id_machine = " + last_id + ";";
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
               
            
        }

        public void AjouterMachine_Load(object sender, EventArgs e)
        {
            CompNum.Text = Compos.RowCount.ToString(); 
        }

        public void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
            FillGrid(component);

        }

        private void CompNum_Click(object sender, EventArgs e)
        {

        }

        private void Addfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pdf files (*.pdf)|Image files (*.jpg)|Image files (*.png)|Image files (*.jpeg)";
            string FilePath = "";
            string appFile = "";
            DialogResult  dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                
                Voir.Visible = true;
               appFile = System.Reflection.Assembly.GetEntryAssembly().Location;

                File.Copy(FilePath,appFile);


            }
        }

        private void Voir_Click(object sender, EventArgs e)
        {
            new List_fichiers().ShowDialog();
        }
    }
}
