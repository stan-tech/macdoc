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
        public string[] refs;
        AutoCompleteStringCollection references;
        public Modifier_composant(Component component)
        {

         
            InitializeComponent();
            ShowInTaskbar = false;
            Owner = new Home();

            this.compon = component;
            CapName.Text = component.Name;
            CapRef.Text = component.Reference;

            CapName.SelectionStart  = component.Name.Length;
            CapRef.SelectionStart = component.Reference.Length;

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
             

             references = DBHelper.SelectAvailableReferences(compon);


            CapRef.AutoCompleteCustomSource = references;
            CapRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CapRef.AutoCompleteSource = AutoCompleteSource.CustomSource;


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
        void Confirmed(object sender, EventArgs e)
        {

            string date = "";

            if (checkBox1.Checked)
            {

                date = DateTime.Now.ToString();

            }
            else
            {
                date = modif.Value.ToString();
            }

            bool replaced = false;
            if(CapRef.Text != compon.Reference)
            {
                replaced = true;
            }
           

            if (DBHelper.PerformModification(compon.ID.ToString(), compon.Reference,CapRef.Text,
                CapName.Text, CapRef.Text, inst.Value.ToString(), date, notes.Text, "1",replaced,compon.Type))
            {
                OnRefreshRequested(EventArgs.Empty);

                this.Close();
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {

            if (!CapRef.Text.Equals(compon.Reference))
            {
                if (!references.Contains(CapRef.Text))
                {
                    DialogResult result = MessageBox.Show("Cette reference n'existe pas. Vous pouvez l'ajouter via le store", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        Arrivage arrivage = new Arrivage(compon.Type, true);
                        arrivage.Name = CapName.Text;
                        arrivage.Reference = CapRef.Text;
                        arrivage.ShowDialog();
                        this.Close();

                        return;
                    }

                }
                else
                {

                    ConfirmAction confirm =
                    new ConfirmAction();
                    confirm.Confirmed += Confirmed;
                    confirm.ShowDialog();

                }

            }
            else
            {
                ConfirmAction confirm =
                    new ConfirmAction();
                confirm.Confirmed += Confirmed;
                confirm.ShowDialog();
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
