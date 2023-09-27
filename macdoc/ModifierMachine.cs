﻿using System;
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
using System.Windows.Forms;

namespace macdoc
{
    public partial class ModifierMachine : Form
    {

        Machine machine;
        int type;
        public bool Added;
        public bool refresh = false;
        public static string component;
        public static DataTable dataTable = new DataTable();
        public ModifierMachine(Machine machine)
        {
            InitializeComponent();
            this.machine = machine;

           
        }

        public void FillGrid(string component)
        {

           
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"]
                  .ConnectionString))
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        try
                        {
                            string sql = "select " + component + ".nom , " + component + ".reference ," +
                    component + ".date_insertion as \"date d'insertion\", " + component + ".date_modification as \" derniére modification\" ," +
                    component + ".life_duration as \"durée de vie\" , num_modification as \"nombre de modification\" from " + component + " where " + component + ".id_machine = " + machine.ID + ";";
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            Compos.Refresh();

                            Compos.DataSource = dataTable;
                             CompNum.Text = Compos.RowCount.ToString();


                    }
                    catch (Exception ex)
                        {
                            MessageBox.Show("Exception " + ex.Message);

                        }
                        conn.Close();

                    }
                    else
                    {


                        conn.Close();


                    }

                }
            


        }
         public  void RefreshRequest(object sender, EventArgs e)
        {
            int index = 0;
            switch (component)
            {
                case "Moteur":
                    index = 1;
                    break;
                case "Reducteur":
                    index = 2;
                    break;
                case "Verin":
                    index = 3;
                    break;
                case"Courroie":
                    index = 4;
                    break;
            }
            caps.SelectedIndex = index;
            FillGrid(component);
        }
        private void ModifierMachine_Load(object sender, EventArgs e)
        {

            MacName.Text = machine.Name;
            TypeCom.SelectedIndex = TypeCom.Items.IndexOf(machine.Type);
            Ref.Text = machine.Reference;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string Query = "update machine set nom = '"+MacName.Text+"' ,  type  = '"+TypeCom.SelectedItem.ToString()+"'  where id = "+machine.ID+";";
            Added = true;
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    SQLiteCommand comm = new SQLiteCommand(Query, connection);

                    if(comm.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("La machine a été modifiée avec succès", "Modification", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Echec !", "Modification", MessageBoxButtons.OK);

                    }


                }
                else
                {
                    connection.Close();
                }
            }
        }

        private void Ajout_button_Click(object sender, EventArgs e)
        {
            component = "Capteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
            FillGrid(component);
        }

        private void Ajout_motor_Click(object sender, EventArgs e)
        {
            component = "Moteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void Ajout_reduc_Click(object sender, EventArgs e)
        {

            component = "Reducteur";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void ajout_courr_Click(object sender, EventArgs e)
        {
            component = "Courroie";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        private void ajout_verin_Click(object sender, EventArgs e)
        {
            component = "Verin";

            Ajouter_composant ajout = new Ajouter_composant(component, machine.ID);

            ajout.RefreshRequest += RefreshRequest;


            ajout.ShowDialog();
        }

        /*
         Tecno-ferrari
Banc
Triage
New-check
CPK
Accoppiatore
Extra-pack
Maxi
         */
        private void ModifierMachine_Shown(object sender, EventArgs e)
        {
            switch (machine.Type)
            {

                case "Tecno-ferrari":

                    type = 0;

                    break;
                case "Banc":

                    type = 1;

                    break;
                case "CPK":

                    type = 4;

                    break;
                case "Accoppiatore":

                    type = 5;
                    break;

                case " Extra-pack":

                    type = 6;

                    break;
                case "Maxi-pack":

                    type = 7;

                    break;
                case "Triage":

                    type = 2;

                    break;

                case "New-check":

                    type = 3;

                    break;

            }

            TypeCom.SelectedIndex = type;


            caps.SelectedIndex = 0;
            component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);


        }
    }
}
