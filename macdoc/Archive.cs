using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        string orderBy = string.Empty;
        string machine_id = string.Empty;
        string user = string.Empty;
        string limit = string.Empty;
        bool mouseClicked = false;
        int direction = 0;
        int ModifgridHeight;
        int MachinegridHeight;
        const int MaxHeight = 1034;
        const int MinHeight = 615;
        bool keepGoing;
        bool PanelShown = false;
        Timer t = new Timer();
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


            //t.Interval = 10;
            //t.Tick += delegate
            //{
            //    if (PanelShown)
            //    {
            //        if (panel2.Height != 860 && panel1.Height != 860)
            //        {
            //            panel2.Height += 86;
            //            panel1.Height -= 86;
            //            PanelShown = true;

            //        }
            //        else
            //            t.Stop();
            //    }
            //    else
            //    {
            //        if (panel2.Height != 10 && panel1.Height != 1660)
            //        {
            //            panel2.Height -= 92;
            //            panel1.Height += 166;
            //            PanelShown = false;
            //        }
            //        else
            //            t.Stop();
            //    }
            //};



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
                    + " (component.nom like '" + SearchModif.Text.Trim() + "%' or component .reference like '" + SearchModif.Text.Trim() + "%' or notes like  '%" +
                    SearchModif.Text + "%') ;";


                connection.Open();

                try
                {
                    if (!Equals(SearchModif.Text, string.Empty))
                    {
                        Modifs.Refresh();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Modifs.DataSource = dataTable;
                    }
                    else
                    {
                        DBHelper.FillArchiveModifications(Modifs, orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);

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
            direction = e.Y;
            ModifgridHeight = this.panel1.Height;
            MachinegridHeight = this.panel2.Height;



        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {



            if ((panel1.Height < MaxHeight && panel2.Height < MaxHeight) &&
                     (panel1.Height > MinHeight && panel2.Height > MinHeight))
            {
                keepGoing = true;
            }
            else
            {

                keepGoing = false;
            }

            if (mouseClicked)
            {

                if (direction > e.Y)
                {


                    // this.panel1.Height = panel1.Height + (panel2.Height - e.Y);
                    // this.Modifs.Height = Modifs.Height + (Modifs.Height - e.Y);

                    // this.panel2.Height = panel1.Height - (panel2.Bottom - panel1.Top);




                    if (keepGoing)
                    {
                        this.panel1.Top = panel1.Top + e.Y;

                        this.panel1.Height += ModifgridHeight / 50;
                        this.panel2.Height -= MachinegridHeight / 120;

                    }
                    /*
                     machine panel size = (2456, 860)  location (-1, 47)

                        modifs panel size (2443, 879) location (0, 898)

                     */

                }
                else
                {

                    if (keepGoing)
                    {
                        this.panel1.Top = panel1.Top + e.Y;

                        this.panel2.Height += MachinegridHeight / 50;
                        this.panel1.Height -= ModifgridHeight / 120;
                    }

                    //this.panel1.Height = panel1.Height - (panel2.Height - e.Y);
                    //this.Modifs.Height = ModifgridHeight - (ModifgridHeight - e.Y);

                    //this.panel2.Height = panel1.Height + (panel2.Bottom - panel1.Top);
                }

            }
        }

        private void AffichierMachines_Click(object sender, EventArgs e)
        {

            if (!PanelShown)
            {


                //modifCollapse.Activate();
                //machineExpand.Activate();

                panel2.Height = 860;
                panel2.Location = new Point(-1, 47);

                panel1.Height = 839;
                panel1.Location = new Point(0, 898);

                AffichierMachines.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                AffichierMachines.Text = "Masquer les machines";
                PanelShown = true;


            }
            else
            {

                //modifExpand.Activate();
                //machineCollapse.Activate();

                panel2.Height = 10;
                panel2.Location = new Point(-1, 47);

                panel1.Height = 1661;
                panel1.Location = new Point(0, 80);

                AffichierMachines.IconChar = FontAwesome.Sharp.IconChar.Eye;
                AffichierMachines.Text = "Afficher les machines";
                PanelShown = false;



            }
        }
    }
}
