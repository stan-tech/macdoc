using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace macdoc
{
    public partial class Ajouter_composant : Form
    {
        string component;
        string id;
        AjouterMachine ajout;
        public event EventHandler RefreshRequest;

        public Ajouter_composant(string component, string id)
        {
            InitializeComponent();
            this.component = component;
            this.id = id;

            if (component != "Courroie" ) {

                this.Text = "Ajouter un " + component;

            }
            else
            {
                this.Text = "Ajouter une " + component;

            }

        }


        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ok_Click(object sender, EventArgs e)
        {

            DateTime date_insertion;

            if(checkBox1.Checked)
            {
                date_insertion = DateTime.Now;
            }
            else
            {
                date_insertion = Date_insertion.Value;
            }
            

            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        string duration = dureeDeVie.Text +" "+cap_vie.SelectedItem.ToString();

                        if (!(Equals(CapName.Text, "") || Equals(CapRef, "")))
                        {
                            string sql = "insert into "+component+" (nom,reference,date_insertion,date_modification,id_machine,life_duration) values('" 
                                + CapName.Text + "','"+CapRef.Text+"','"
                                + date_insertion.ToString() + "','"
                                + date_insertion.ToString() + "','"+id+"','"+duration+"');";


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
                    catch(Exception ex)
                    {
                        if (ex.Message.ToLower().Contains("unique"))
                        {
                            MessageBox.Show("Echec ! Un "+component+" avec le meme reference s'existe déjà", "Ajout", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("Echec ! ", "Echec d'ajouter un "+component, MessageBoxButtons.OK,MessageBoxIcon.Error);

                        }



                    }
                }
                else
                {


                    conn.Close();


                }




            }


        }

        public virtual void OnRefreshRequested(EventArgs e )
        {

            EventHandler eh = RefreshRequest;

            if (eh != null)
            {
                eh(this, e);
            }

        }
        private void Ajouter_composant_Load(object sender, EventArgs e)
        {

            cap_vie.DroppedDown = false;
            cap_vie.SelectedIndex = 0;
            cap_vie.DroppedDown = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Date_insertion.Enabled = false;

            }
            else
            {
                Date_insertion.Enabled = true;
            }
        }
    }
}
