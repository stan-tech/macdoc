using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Store : Form
    {
        bool ButtonCreated = false;
        Point CaporiginalLocation, MotOrigin, RedOrigin, CourrOrigin, HOrigin;
        string SelectedComponent = "";
        bool isDragged = false;
        Point ptOffset;
        RoundedButton btn;

        public Store()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            HOrigin = ajouver.Location;
            CaporiginalLocation = Ajout_cap.Location;
            MotOrigin = Ajoumot.Location;
            CourrOrigin = AjouCour.Location;
            RedOrigin = Ajoured.Location;

            foreach (Control b in MainPanel.Controls)
            {
                if (b is RoundedButton)
                {
                    ControlExtension.Draggable(b, true);


                }
            }
        }

        private async void Store_Load(object sender, EventArgs e)
        {

            Compos.DataSource = await DBHelper.FillStoreGrid();
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {


        }


        private void Ajout_button_Click(object sender, EventArgs e)
        {

        }




        private void Ajout_button_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                btn = (RoundedButton)sender;


            }
            else
            {
                isDragged = false;
            }

            //  InstantiateButton(Ajout_button);
        }


        private void Ajout_button_MouseUp(object sender, MouseEventArgs e)
        {

            Ajout_cap.Location = CaporiginalLocation;
            isDragged = false;

        }

        private void Ajout_button_DragDrop(object sender, DragEventArgs e)
        {
            ptOffset = new Point(Ajout_cap.Location.X - Cursor.Position.X, Ajout_cap.Location.Y - Cursor.Position.Y);

        }

        private void Ajout_button_DragOver(object sender, DragEventArgs e)
        {
            if (Ajout_cap.Bounds.IntersectsWith(Compos.Bounds))
            {
                panel1.Enabled = true;
                Qt.Text = "Capteur";
                Ajouter.BackColor = Color.DarkTurquoise;
                Ajouter.IconSize = 48;

                Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
                Qt.Focus();
                Qt.SelectAll();
                SelectedComponent = "Capteur";
            }
        }



        private void Ajoured_MouseUp(object sender, MouseEventArgs e)
        {
            Ajoured.Location = RedOrigin;
            isDragged = false;

        }

        private void Ajoured_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle sr = new Rectangle(Ajoured.Left, Ajoured.Top, Ajoured.Width, Ajoured.Height);

            Rectangle r = new Rectangle(Compos.Left, Compos.Top, Compos.Width, Compos.Height);
            if (sr.IntersectsWith(r))
            {

                panel1.Enabled = true;
                Ajouter.Text = "Ajouter des reducteurs";
                Ajouter.BackColor = Color.DarkTurquoise;
                Ajouter.IconSize = 48;

                Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
                Qt.Focus();
                Qt.SelectAll();
                SelectedComponent = "Reducteur";

            }
        }



        private void ajouver_MouseUp(object sender, MouseEventArgs e)
        {
            ajouver.Location = HOrigin;
            isDragged = false;

        }

        private async void Ajouter_Click(object sender, EventArgs e)
        {
            if (SelectedComponent == "")
            {
                MessageBox.Show("Selectionner un composant d'abbord", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DBHelper.AddToStore(Qt.Text, price.Text, SelectedComponent)){

                    Compos.DataSource = await DBHelper.FillStoreGrid();

                }
            }
        }

        private void AjouCour_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle sr = new Rectangle(AjouCour.Left, AjouCour.Top, AjouCour.Width, AjouCour.Height);

            Rectangle r = new Rectangle(Compos.Left, Compos.Top, Compos.Width, Compos.Height);
            if (sr.IntersectsWith(r))
            {

                panel1.Enabled = true;
                Ajouter.Text = "Ajouter des courroies";
                SelectedComponent = "Courroie";

            }
        }

        private void AjouCour_MouseUp(object sender, MouseEventArgs e)
        {
            AjouCour.Location = CourrOrigin;
            isDragged = false;


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }

        private void Store_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void Retirer_Click(object sender, EventArgs e)
        {
            Ajouter.BackColor = Color.Orange;
            Ajouter.Text = "Selectionnez un componsant";
            Ajouter.IconChar = FontAwesome.Sharp.IconChar.Trash;

        }

        

        private void Compos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch(Compos.SelectedRows[0].Cells[0].Value.ToString()){

                case "Capteur" :

                    Ajouter.Text = "Retirer des capteurs";
                    break;
                case "Reducteur":

                    Ajouter.Text = "Retirer des reducteurs";
                    break;
                case "Moteur":

                    Ajouter.Text = "Retirer des moteurs";
                    break;
                case "Courroie":

                    Ajouter.Text = "Retirer des courroies";
                    break;
                case "Huile":

                    Ajouter.Text = "Retirer d'huile";

                    break;

            }
            Ajouter.BackColor = Color.Orange;
            Ajouter.IconSize = 28;
            price.Text = Compos.SelectedRows[0].Cells[2].Value.ToString();

            Qt.Focus();
            Qt.SelectAll();
            Ajouter.IconChar = FontAwesome.Sharp.IconChar.Trash;
        }

        private void ajouver_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle sr = new Rectangle(ajouver.Left, ajouver.Top, ajouver.Width, ajouver.Height);

            Rectangle r = new Rectangle(Compos.Left, Compos.Top, Compos.Width, Compos.Height);
            if (sr.IntersectsWith(r))
            {

                panel1.Enabled = true;
                Ajouter.Text = "Ajouter d'huile";
                Ajouter.BackColor = Color.DarkTurquoise;
                Ajouter.IconSize = 48;

                Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
                Qt.Focus();
                Qt.SelectAll();

                SelectedComponent = "huile";

            }
        }

        private void Ajout_button_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle sr = new Rectangle(Ajout_cap.Left, Ajout_cap.Top, Ajout_cap.Width, Ajout_cap.Height);

            Rectangle r = new Rectangle(Compos.Left, Compos.Top, Compos.Width, Compos.Height);
            if (sr.IntersectsWith(r))
            {

                panel1.Enabled = true;
                Ajouter.Text = "Ajouter des capteurs";
                Ajouter.BackColor = Color.DarkTurquoise;
                Ajouter.IconSize = 48;
                SelectedComponent = "Capteur";

                Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
                Qt.Focus();
                Qt.SelectAll();

            }



        }



        private void Ajoumot_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle sr = new Rectangle(Ajoumot.Left, Ajoumot.Top, Ajoumot.Width, Ajoumot.Height);

            Rectangle r = new Rectangle(Compos.Left, Compos.Top, Compos.Width, Compos.Height);
            if (sr.IntersectsWith(r))
            {

                panel1.Enabled = true;
                Ajouter.Text = "Ajouter des moteurs";
                Ajouter.BackColor = Color.DarkTurquoise;
                Ajouter.IconSize = 48;

                Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
                Qt.Focus();
                Qt.SelectAll();
                SelectedComponent = "Moteur";

            }
        }

        private void Ajoumot_MouseUp(object sender, MouseEventArgs e)
        {
            Ajoumot.Location = MotOrigin;

            isDragged = false;

        }
    }
}
