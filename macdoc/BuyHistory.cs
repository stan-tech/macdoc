using FontAwesome.Sharp;
using Infragistics.Windows.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class BuyHistory : Form
    {


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
        public BuyHistory()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90));

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.ShowDialog();
            this.Close();
        }

        string selectionType = "";
        private async void NC_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.BlueViolet;
            Nouveaux.BackColor = System.Drawing.Color.Indigo;
            Remp.BackColor = System.Drawing.Color.Indigo;
            // Compos.DataSource = await DBHelper.SelectUsedComponents();

            selectionType = "u";
            DBHelper.SelectStoreComponents(Compos, selectionType, false,"");

        }

        private void Nouveaux_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.Indigo;
            Nouveaux.BackColor = System.Drawing.Color.BlueViolet;
            Remp.BackColor = System.Drawing.Color.Indigo;
            selectionType = "n";
            DBHelper.SelectStoreComponents(Compos,selectionType,false,"");

        }

        private void Remp_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.Indigo;
            Nouveaux.BackColor = System.Drawing.Color.Indigo;
            Remp.BackColor = System.Drawing.Color.BlueViolet;
            selectionType = "r";
            DBHelper.SelectStoreComponents(Compos, selectionType, false,"");

        }

        private async void BuyHistory_Load(object sender, EventArgs e)
        {
            NC.PerformClick();
            DBHelper.SelectNumber(Nouveaux,NC, Remp);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (!Search.Text.Equals(""))
            {
                DBHelper.SelectStoreComponents(Compos, selectionType, true, Search.Text);
            }
            else
            {
                DBHelper.SelectStoreComponents(Compos, selectionType, false, "");

            }

        }
    }
}
