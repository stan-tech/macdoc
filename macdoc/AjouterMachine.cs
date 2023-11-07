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
            ShowInTaskbar = false;

            if (refresh)
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

   

        private void Ok_Click(object sender, EventArgs e)
        {
            machine = MacName.Text;


            if (!(MacName.Text =="" || Ref.Text == "" || TypeCom.SelectedItem ==null) )
            {
                last_id = DBHelper.InsertMachine(machine, SelectedType, Ref.Text, datepicker.Value.ToString()
                      , component);

                if (last_id != "0")
                {

                    empty = false;
                    Added = true;

                }
            }
            else
            {
                MessageBox.Show("Echec ! , Veuillez remplisser tout les champs", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        SQLiteCommand command = new SQLiteCommand("select count(id) " +
                            "from component where id_machine = " + last_id + ";", connection);

                        SQLiteDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

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
                DBHelper.FillAddMachineComponentGrid(component,dataTable,Compos,last_id);
            }
               
            
        }

        public void AjouterMachine_Load(object sender, EventArgs e)
        {
            datepicker.Value = DateTime.Now;
            CompNum.Text = Compos.RowCount.ToString(); 
        }

        public void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            Composants.Text = caps.SelectedItem.ToString();
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
            FillGrid(component);
            CompNum.Text  = Compos.RowCount.ToString(); 

        }

        private void CompNum_Click(object sender, EventArgs e)
        {

        }

        private void Addfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selectionnez un fichier pdf";
            openFileDialog1.Filter = "Pdf files |*.pdf";
            string FilePath = "";
            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\Manuals", appFile = "";
            
            string fileName,file_id = Guid.NewGuid().ToString();


            if (Added)
            {

                DialogResult dr = openFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    FilePath = openFileDialog1.FileName;

                    
                    appFile = directory +"\\"+file_id+".pdf";
                    fileName = Path.GetFileName(FilePath)+Path.GetFileName(appFile);



                    if (DBHelper.InsertIntoFiles(file_id, fileName, "1",appFile, DateTime.Now, last_id) > 0)
                    {

                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);

                        }


                        File.Copy(FilePath, appFile);

                    }
                    else
                    {
                       DialogResult result = MessageBox.Show("Une erreur se produite , reéssayer  ", "    Erreur"
                           ,MessageBoxButtons.RetryCancel);

                        while(result == DialogResult.Retry)
                        {
                            if (DBHelper.InsertIntoFiles(file_id, fileName, "1", appFile, DateTime.Now, last_id)>0)
                            {
                                Voir.Visible = true;
                                Voir.Enabled=true;

                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }


                    Voir.Visible = true;
                    Voir.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("veuillez d'abord confimer l'ajout de la machine ");
            }
        }

        private void Voir_Click(object sender, EventArgs e)
        {
            new List_fichiers(MacName.Text,last_id).ShowDialog();
        }
    }
}
