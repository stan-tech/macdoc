using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class List_fichiers : Form
    {
        public List_fichiers()
        {
            InitializeComponent();
        }

        private void List_fichiers_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
