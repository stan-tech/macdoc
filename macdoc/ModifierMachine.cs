using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class ModifierMachine : Form
    {

        Machine machine;
        int type;
        public bool Added;
        public bool refresh = false;
        public static string component;
        public static DataTable dataTable = new DataTable();
        public ModifierMachine(Machine machine)
        {
            InitializeComponent();
            this.machine = machine;
            ShowInTaskbar = false;
            Owner = new Home();


        }

        public void FillGrid(string component)
        {

           
              DBHelper.FillModifGrid(machine, component,Compos,dataTable,CompNum);
            


        }
         public  void RefreshRequest(object sender, EventArgs e)
        {
            int index = 0;
            switch (component)
            {
                case "Moteur":
                    index = 1;
                    break;
                case "Reducteur":
                    index = 2;
                    break;
                case "Verin":
                    index = 3;
                    break;
                case"Courroie":
                    index = 4;
                    break;
            }
            caps.SelectedIndex = index;
            FillGrid(component);
        }
        private void ModifierMachine_Load(object sender, EventArgs e)
        {

            MacName.Text = machine.Name;
            TypeCom.SelectedIndex = TypeCom.Items.IndexOf(machine.Type);
            Ref.Text = machine.Reference;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string Query = "update machine set nom = '"+MacName.Text+"' ,  type  = '"+TypeCom.SelectedItem.ToString()+"'  where id = "+machine.ID+";";
            Added = true;
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    SQLiteCommand comm = new SQLiteCommand(Query, connection);

                    if(comm.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("La machine a été modifiée avec succès", "Modification", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Echec !", "Modification", MessageBoxButtons.OK);

                    }


                }
                else
                {
                    connection.Close();
                }
            }
        }

        private void Ajout_button_Click(object sender, EventArgs e)
        {
            component = "Capteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
            FillGrid(component);
        }

        private void Ajout_motor_Click(object sender, EventArgs e)
        {
            component = "Moteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void Ajout_reduc_Click(object sender, EventArgs e)
        {

            component = "Reducteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void ajout_courr_Click(object sender, EventArgs e)
        {
            component = "Courroie";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void ajout_verin_Click(object sender, EventArgs e)
        {
            component = "Verin";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        /*
         Tecno-ferrari
Banc
Triage
New-check
CPK
Accoppiatore
Extra-pack
Maxi
         */
        private void ModifierMachine_Shown(object sender, EventArgs e)
        {
            switch (machine.Type)
            {

                case "Tecno-ferrari":

                    type = 0;

                    break;
                case "Banc":

                    type = 1;

                    break;
                case "CPK":

                    type = 4;

                    break;
                case "Accoppiatore":

                    type = 5;
                    break;

                case " Extra-pack":

                    type = 6;

                    break;
                case "Maxi-pack":

                    type = 7;

                    break;
                case "Triage":

                    type = 2;

                    break;

                case "New-check":

                    type = 3;

                    break;

            }

            TypeCom.SelectedIndex = type;


            caps.SelectedIndex = 0;
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);


        }

        private void Addfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selectionnez un fichier pdf";
            openFileDialog1.Filter = "Pdf files |*.pdf";
            string FilePath = "";
            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\Manuals", appFile = "";

            string fileName, file_id = Guid.NewGuid().ToString();

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;


                appFile = directory + "\\" + file_id + ".pdf";
                fileName = Path.GetFileName(FilePath) + Path.GetFileName(appFile);



                if (DBHelper.InsertIntoFiles(file_id, fileName, "1", appFile, DateTime.Now, machine.ID) > 0)
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
                        , MessageBoxButtons.RetryCancel);

                    while (result == DialogResult.Retry)
                    {
                        if (DBHelper.InsertIntoFiles(file_id, fileName, "1", appFile, DateTime.Now, machine.ID) > 0)
                        {
                            Voir.Visible = true;
                            Voir.Enabled = true;

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

        private void Voir_Click(object sender, EventArgs e)
        {
            new List_fichiers(MacName.Text, machine.ID).ShowDialog();

        }

        private void Compos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Composants_Click(object sender, EventArgs e)
        {

        }
    }
}
