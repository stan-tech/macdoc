using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Store : Form
    {
        bool ButtonCreated = false;
        string SelectedComponent = "";
        bool isDragged = false;
        Point ptOffset;
        RoundedButton btn;
        int Operation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Store()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height,90, 90));

            ControlExtension.Draggable(this,true);
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



     

        private async void Ajouter_Click(object sender, EventArgs e)
        {
            
            if (SelectedComponent == "")
            {
                MessageBox.Show("Selectionner un composant d'abbord", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
            }
            
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
        //    Qt.Focus();
        //    Qt.SelectAll();
        //    Operation = 0;

        }

        

        private void Compos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* switch(Compos.SelectedRows[0].Cells[0].Value.ToString()){

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

             }*/
            contextMenuStrip1.Show(Cursor.Position);
          



        }


        private void Ajout_menu_click(object sender, EventArgs e)
        {
            new Arrivage(SelectedComponent,true).ShowDialog();

            //Qt.Focus();
            //Qt.SelectAll();
            //Operation = 1;
        }

        private void Compos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedComponent = Compos.SelectedRows[0].Cells[0].Value.ToString();

            contextMenuStrip1.Show(Cursor.Position);
            //price.Text = Compos.SelectedRows[0].Cells[2].Value.ToString();
            //SelectedComponent = Compos.SelectedRows[0].Cells[0].Value.ToString();

            //Qt.Focus();
            //Qt.SelectAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void caps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public async void Added(object sender, EventArgs e)
        {



            try
            {
                Compos.DataSource = await DBHelper.FillStoreGrid();

            }
            catch (Exception)
            {

                throw;
            }
           

        }
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Arrivage arrivage = new Arrivage(SelectedComponent,true);
            arrivage.added += Added;

            arrivage.ShowDialog();


        }

        private void bilans_Click(object sender, EventArgs e)
        {
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            BuyHistory history = new BuyHistory();
            history.ShowDialog();
            this.Close();


        }
    }
}
