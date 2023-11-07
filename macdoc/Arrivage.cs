using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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
        Dictionary<string, double> prices= new Dictionary<string, double>();
        string name, reference;

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
        public string Name
        {
            get { return this.name; }
           set {this.name = value; }

        }
        public string Reference
        {
            get { return this.reference; }
            set { this.reference = value; }

        }

        private void Arrivage_Load(object sender, EventArgs e)
        {
            if(name!= null && reference != null){
                CapName.Text = name;
                CapRef.Text = reference;
                
            }
            cap_vie.SelectedIndex = 0;
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
                dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Type"), new DataColumn("Name"), new DataColumn("Reference"), new DataColumn("Life duration"), new DataColumn("Quantity") });
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
                component.Life_duration = dureeDeVie.Text + " " + cap_vie.SelectedItem.ToString();

            string unit_ = unit.SelectedItem.ToString();

               component.Unit = (unit_ == "Litre") ? component.Unit = "Litre" : component.Unit = "Unit";

            if (!prices.ContainsKey(selected_component))
            {
                prices.Add(selected_component, double.Parse(price_unit.Text));
            }
            else
            {
                prices[selected_component] = double.Parse(price_unit.Text);
            }

                componentList.Add(component);

                dt.Rows.Add(component.Type, component.Name, component.Reference, component.Life_duration, component.Quantity);
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


            if (DBHelper.AddToStore(componentList,prices))
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

             selected_component = caps.SelectedItem.ToString();
            
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {

                        string com = "select unit , MAX(price_) from component_store where type = '"
                            + selected_component + "'; ";
                        SQLiteCommand cmd = new SQLiteCommand(com, conn);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                           unit.SelectedIndex =( reader.GetString(0) == "Unit") ? 1 :  0;


                            price_unit.Text = reader.GetDouble(1).ToString();



                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    conn.Close();
                }
            
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

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            int qt = int.Parse(Qt.Text);
            qt -= 5;
            Qt.Text = qt.ToString();
        }

        private void price_unit_TextChanged(object sender, EventArgs e)
        {
            if (price_unit.Text != "")
            {
                price.Text = (double.Parse(price_unit.Text) * double.Parse(Qt.Text)).ToString();
            }
        }
    }
}
