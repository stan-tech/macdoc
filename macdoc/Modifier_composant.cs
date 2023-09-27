using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Modifier_composant : Form
    {
        string type;
        string id;
        public Component compon;
        public event EventHandler cap_Changed;
        public Modifier_composant(Component component)
        {

         
            InitializeComponent();

            this.compon = component;
            CapName.Text = component.Name;
            CapRef.Text = component.Reference;


            inst.Format = DateTimePickerFormat.Short;

            modif.Format = DateTimePickerFormat.Short;

            inst.CustomFormat = "dd/MM/yyyy";
            modif.CustomFormat = "dd/MM/yyyy";
            inst.Value = component.Date_insertion;
            modif.Value  = component.Date_modification;

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string  date = inst.Value.ToString();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                modif.Enabled = false;

            }
            else
            {
                modif.Enabled = true;
            }



        }

        public virtual void OnRefreshRequested(EventArgs e)
        {

            EventHandler eh = cap_Changed;

            if (eh != null)
            {

                eh(this, e);
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {


            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                string sql = "";

                string date = "";

                if (checkBox1.Checked)
                {

                    date = DateTime.Now.ToString();

                }
                else
                {
                    date = modif.Value.ToString();
                }


                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {

                        if (!(Equals(CapName.Text, "") || Equals(CapRef, "")))
                        {

                                sql = "update  " + compon.Type + " set nom = '" + CapName.Text + "'" +
                                    ",reference = '" + CapRef.Text + "',date_insertion = '" + inst.Value.ToString() +
                                    "',date_modification = '" +date+ "' , num_modification = num_modification + 1 " +
                                    "where id = "+compon.ID+";";
                            
                        


                            SQLiteCommand command = new SQLiteCommand(sql, conn);


                            if (command.ExecuteNonQuery() > 0)
                            {

                                conn.Close();


                                OnRefreshRequested(EventArgs.Empty);

                                this.Close();


                            }
                            else
                            {
                                MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                            }

                        }
                        else
                        {

                            MessageBox.Show("Echec !", "Ajout", MessageBoxButtons.OK);


                        }




                    }
                    catch (Exception ex)
                    {
                        
                        
                            MessageBox.Show("Echec ! "+ex.Message, "Echec d'ajouter un composant", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                    }
                }
                else
                {


                    conn.Close();


                }




            }

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                modif.Enabled = false;

            }
            else
            {
                modif.Enabled = true;
            }

        }
    }
}
