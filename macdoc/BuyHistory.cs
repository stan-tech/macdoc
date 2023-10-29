using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void NC_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.BlueViolet;
            Nouveaux.BackColor = System.Drawing.Color.Indigo;
            Remp.BackColor = System.Drawing.Color.Indigo;
        }

        private void Nouveaux_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.Indigo;
            Nouveaux.BackColor = System.Drawing.Color.BlueViolet;
            Remp.BackColor = System.Drawing.Color.Indigo;
        }

        private void Remp_Click(object sender, EventArgs e)
        {
            NC.BackColor = System.Drawing.Color.Indigo;
            Nouveaux.BackColor = System.Drawing.Color.Indigo;
            Remp.BackColor = System.Drawing.Color.BlueViolet;
        }

        private async void BuyHistory_Load(object sender, EventArgs e)
        {
            NC.PerformClick();
            Compos.DataSource = await DBHelper.FillStoreGrid();
        }
    }
}
