using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            ShowInTaskbar = false;

        }

        private async void Store_Load(object sender, EventArgs e)
        {
           Compos.DataSource = await DBHelper.FillStoreGrid();
        }

    
    }
}
