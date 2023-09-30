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

        string id_machine,machineName;
        public List_fichiers(string machineName,string id_machine)
        {
            InitializeComponent();
            this.id_machine = id_machine;
            this.machineName = machineName;
        }

        private void List_fichiers_Load(object sender, EventArgs e)
        {
            MachineName.Text = machineName;
            DBHelper.SelectFilesByID(metroGrid1, id_machine);

            FileNum.Text = metroGrid1.RowCount.ToString();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(metroGrid1.SelectedRows[0].Cells[4].Value.ToString());

            }
            catch (Exception)
            {

                MessageBox.Show("Fichier non trouvé ","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
