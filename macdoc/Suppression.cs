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
    public partial class Suppression : Form
    {

        Machine machine;
        public Suppression(Machine machine)
        {
            this.machine = machine;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Suppression_Load(object sender, EventArgs e)
        {
            ComponentName.Text = machine.Name;
            Ref.Text = machine.Reference;
        }
    }
}
