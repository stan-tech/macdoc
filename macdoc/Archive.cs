using Org.BouncyCastle.Crypto.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        string orderBy = "";
        string machine_id="";
        string user = "";
        string limit = "";
        bool mouseClicked = false;
        int direction = 0;
        private void Archive_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            TrierPar.SelectedIndex = 0;


        }

        private void Archive_Shown(object sender, EventArgs e)
        {
            Limit.SelectedIndex = 0;
            Type.SelectedIndex = 0;
            Components.SelectedIndex = 0;
            DBHelper.SelectAllUsers(Modificateurs);
            limit = Limit.SelectedItem.ToString();
            
            Modificateurs.SelectedIndex = 0;
            


        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBHelper.SelectMachineByType(metroGrid1, Type.SelectedItem.ToString());
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrierPar_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (TrierPar.SelectedItem.ToString())
            {

                case "Nom du composant":

                    orderBy = "component.nom";
                    break;
                case "Date ascendante":
                    orderBy = "component.date_modification asc";
                    break;
                case "Date descendante":
                    orderBy = "component.date_modification desc";
                    break;

            }

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, "Tout", "Tout", "Tout");


            }
            else
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);


            }
        }

      


        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                connection.Open();
                try
                {
                    machine_id = new SQLiteCommand("select id from machine where reference = '" + metroGrid1.SelectedRows[0].Cells[2].Value.ToString()
                           + "';", connection).ExecuteScalar().ToString();
                }
                catch (Exception)
                {

                    throw;
                }


                connection.Close();
            }

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, "Tout", "Tout", "Tout");


            }
            else
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);

            }
        }

        private void SearchModif_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

               




                string command = "select machine.nom as machine, component.type , component.nom as nom, component.reference, users.nom as modificateur , date_modification as \"derniére modification\" , notes from modification inner join component" +
                           " on modification.id_composant = component.id  inner join users on users.id = component.modificateur inner join machine on  component.id_machine = machine.id where "
                    + " (component.nom like '" + SearchModif.Text.Trim() + "%' or component .reference like '" + SearchModif.Text.Trim() + "%' or notes like  '%"+
                    SearchModif.Text+"%') ;";


                connection.Open();

                try
                {
                    if (!Equals(SearchModif.Text, ""))
                    {
                        Modifs.Refresh();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Modifs.DataSource = dataTable;
                    }
                    else
                    {
                        DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(),user,limit);

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Echec !" + ex.Message, "Ajout", MessageBoxButtons.OK);

                }
                connection.Close();
            }
        }

        private void Componenets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {

                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, "Tout", "Tout", "Tout");

            }
            else
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);


            }
        }

        private void Modificateurs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, "Tout", "Tout", "Tout");


            }
            else
            {
                user = Modificateurs.SelectedItem.ToString();

                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);

            }
        }

        private void Limit_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, "Tout", "Tout", "Tout");


            }
            else
            {
                limit = Limit.SelectedItem.ToString();

                DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);


            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
             mouseClicked = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
             direction = e.Y;

            if (mouseClicked)
            {
              
                
                    this.panel1.Top = panel1.Top + e.Y;
                    this.panel1.Height = panel1.Height + (panel2.Height - e.Y);
                    this.panel2.Height = panel1.Height - (panel2.Bottom - panel1.Top);
                

            }
        }
    }
}
