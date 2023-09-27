using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace macdoc
{
    public partial class ListDesMachine : Form
    {
        string operation;
        string SelectedType;
        public static  string Edit = "edit";
        public static string Del = "del";
        public static string Con = "Con";

        public ListDesMachine(string operation)
        {
            InitializeComponent();

               this.operation = operation;
            //    types.SelectedIndex = 0;
            //SelectedType = types.SelectedItem.ToString();
            


        }

        private void types_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedType = types.SelectedItem.ToString();
            FillGrid();

        }

        public void FillGrid()
        {

            string sqlcommand = "select nom ,type , reference, date_installation as \"date d'installation\" from machine"
                + " where type = '"+SelectedType+"';";

            
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                connection.Open();




                SQLiteCommand cmd = new SQLiteCommand(sqlcommand, connection);

                

                metroGrid1.Refresh();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcommand, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                metroGrid1.DataSource = dataTable;
              
                connection.Close();


            }

        }

        private void ListDesMachine_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0] ;

            FillGrid();
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string IdQuery = "select id from machine where nom =  '"+metroGrid1.SelectedRows[0].Cells[0].Value.ToString()+"';";
            string id = "";
            Machine machine = null;

            using(SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    SQLiteCommand comm = new SQLiteCommand(IdQuery, connection);
                    id = comm.ExecuteScalar().ToString();


                }
                else
                {
                    connection.Close();
                }
            }

            machine = new Machine(metroGrid1.SelectedRows[0].Cells[0].Value.ToString(),
            metroGrid1.SelectedRows[0].Cells[1].Value.ToString(),id, metroGrid1.SelectedRows[0].Cells[2].Value.ToString());

            Form OP;
            OP =  Equals(operation,Edit) ? (Form) new ModifierMachine(machine) :  new Suppression(machine) ;


            OP.ShowDialog();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           SelectedType = treeView1.SelectedNode.Text;
            FillGrid();
            CompNum.Text = metroGrid1.RowCount.ToString();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
