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
    public partial class Arrivage : Form
    {
        string selected_component;
        DataTable dt;
        List<Component> componentList = new List<Component>();
        bool notCreated = false;
        public EventHandler added;
        bool allowChangeType ;


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
        public Arrivage(string selected_component, bool allowChangeType)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90));

            this.selected_component = selected_component;
            this.allowChangeType = allowChangeType;

        }

        private void Arrivage_Load(object sender, EventArgs e)
        {
            switch(selected_component)
            {
                case "Capteur":
                    caps.Enabled = false;

                    caps.SelectedIndex = 0;
                    break;
                case "Moteur":
                    caps.Enabled = false;
                    caps.SelectedIndex = 1;
                    break;
                case "Reducteur":
                    caps.Enabled = false;
                    caps.SelectedIndex = 2;
                    break;
                case "Huile":
                    caps.Enabled = false;
                    caps.SelectedIndex = 3;
                    break;
                case "Courroie":
                    caps.Enabled = false;
                    caps.SelectedIndex = 4;
                    break;
                default:
                    allowChangeType = false;
                    break;
            }
            if (!notCreated)
            {
                dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Type"), new DataColumn("Name"), new DataColumn("Reference"), new DataColumn("Life duration"), new DataColumn("Inserted"), new DataColumn("Quantity") });
                Compos.DataSource = dt;

                notCreated = true;
            }


        }

        private void Ok_Click(object sender, EventArgs e)
        {
            
                Component component = new Component(CapName.Text, CapRef.Text, 
                DateTime.MinValue, DateTime.MinValue, 0, false);
                component.Price = price_unit.Text;
                component.Type = selected_component;
                 component.Quantity = int.Parse(Qt.Text);

                componentList.Add(component);

                dt.Rows.Add(component.Type, component.Name, component.Reference, component.Life_duration, component.Inserted,component.Quantity);
                Compos.DataSource = dt;
            
            



        }

        private void Annuler_Click(object sender, EventArgs e)
        {

        }

        void OnAdded(EventArgs eventArgs)
        {
            EventHandler handler = added;
            if (handler != null) { 
            
                handler(this, eventArgs);
            
            }

        }
        private async void Ajouter_Click(object sender, EventArgs e)
        {

            if (DBHelper.AddToStore(componentList))
            {
                this.componentList.Clear();

                this.Close();
                OnAdded(EventArgs.Empty);
            }
        }

        private void price_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& e.KeyChar !='.')
            {
                MessageBox.Show("Please enter only numbers.");

                e.Handled = true;
            }
        }

        private void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!allowChangeType)
            {
                caps.Enabled = false;
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.')
            {
                MessageBox.Show("Please enter numbers only .");

                e.Handled = true;
            }
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            int qt = int.Parse(Qt.Text);
            qt+=5;
            Qt.Text = qt.ToString();
        }

        private void Qt_TextChanged(object sender, EventArgs e)
        {
            if (price_unit.Text != "")
            {
                price.Text = (double.Parse(price_unit.Text)*double.Parse(Qt.Text)).ToString();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.ShowDialog();
            this.Close();
        }
    }
}
