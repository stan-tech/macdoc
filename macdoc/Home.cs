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
using System.Windows.Forms.VisualStyles;
using System.Windows.Markup;
using MaterialSkin;
using System.Configuration;
using System.Data.SQLite;
using FontAwesome.Sharp;
using System.Collections;
using MetroFramework.Controls;
using System.Management;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Security.Cryptography.Xml;
using System.Diagnostics;
using System.Windows.Shapes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Web.UI;
using System.Web;

using System.Windows.Documents;
using DevExpress.XtraExport.Implementation;
using Spire.Pdf.Tables;
using static DevExpress.Utils.Svg.CommonSvgImages;
using iTextSharp.text.pdf.draw;

namespace macdoc
{
    public partial class Home : Form

    {
        string selected_component;
        string selected_machine;
        Machine machine;
        bool expanded = false;
        public Form ajouter_machine;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (

            int nLeftRect,
            int nTopRect,
            int nBottomRect,
            int nRightRect,
            int nWidthEllipse,
            int nHeightEllipse


            );


        MaterialSkinManager skinManager;
        ThemeSizeType themeSizeType;
        private bool start;
        private string SelectedMachineType;



        protected override void OnPaint(PaintEventArgs e) { }

        public Form Ajout
        {
            get { return ajouter_machine; }
            set { ajouter_machine = value; }


        }

        public Home()
        {
            this.DoubleBuffered = true;
            

            InitializeComponent();
        

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        public int SelectItems()
        {
            caps.SelectedIndex = 0;
            selected_component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);
            machineCombo.SelectedIndex = 0;
            selected_machine = machineCombo.SelectedItem.ToString();

            return 1;
        }
        public void StartFilling()
        {
           
            async Task Do()
            {
                SelectItems();

                await Task.Run(()=>
                StartFilling());

                await Task.Run(()=> Synth_Click(this, null));


                await Task.Run(()=> DBHelper.FillHomeGrid(metroGrid1,
                selected_component,
                selected_machine));

            }
            
        }
        private void Home_Load(object sender, EventArgs e)
        {

            SelectItems();

        }

        public void CollapseMenu()
        {
            var start = 5;
            var end = 532;
            var steps = 13;
            for (int i = 0; i <= steps; i++)
            {
                // The type conversion is necessary because both i and steps are integers

               int  x =  new Random().Next(0, 6);
               // var value = Mathf.Lerp(start, end, i / (float)steps);

                //MessageBox.Show(value);
            }


            if (panel1.Width > 200)
            {


                collapse.Start();
                combos_anim_left.Start();
                Grid_anim_left.Start();
                CapLabel_anim_left.Start();

            }
            else
            {
                expand.Start();

                combos_anim.Start();
                GridAnim.Start();
                Caplabel_anim.Start();
            }
        }

     

        private void MenuButton_Click_1(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
                    }

        private void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            Composants.Text = caps.SelectedItem.ToString();
            selected_component = caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1);

            if (selected_machine != null)
            {
                DBHelper.FillHomeGrid(metroGrid1,
                                selected_component,
                                selected_machine); 
                CompNum.Text = DBHelper.SelectComponentNumber(selected_component,selected_machine);
                SelectMachineNumber(SelectedMachineType);

            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private void Synth_Click(object sender, EventArgs e)
        {
            Syn_types.Controls["Tri"].Text = "Triage";
            Syn_types.Controls["NC"].Text = "New-check";
            IconButton c = (IconButton)Syn_types.Controls["NC"];
            IconButton s = (IconButton)Syn_types.Controls["Tri"];

            c.IconChar = IconChar.StackOverflow;
            s.IconChar = IconChar.StackOverflow;

            zeroitAnimatorEdit1.Activate();

            iconButton6_Click(this, e);
            Synth.BackColor = System.Drawing.Color.LightGray;
            NC.BackColor = System.Drawing.Color.LightGray;
            Tecnoferrari.BackColor = System.Drawing.Color.Transparent;

            Banc.BackColor = System.Drawing.Color.Transparent;
            accoppiatore.BackColor = System.Drawing.Color.Transparent;
            Palettiseur.BackColor = System.Drawing.Color.Transparent;
            CPK.BackColor = System.Drawing.Color.Transparent;
          


        }


        public void selectMachines(string type)
        {
            int machine = 0;
            switch (type)
            {
                case "Tecno-ferrari":

                    machine = 0; 

                    break;
                case "Banc":

                    machine =1;

                    break;
                case "CPK":

                    machine = 4;

                    break;
                case "Accoppiatore":

                    machine = 5;

                    break;

                case "Extra-pack":

                    machine = 6;

                    break;
                case "Maxi-pack":

                    machine = 7;

                    break;
                case "Triage":

                    machine = 2;

                    

                    break;
                case "New-check":

                    machine = 3;

                    break;

            }
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    try
                    {
                        string sql = "select nom from machine where type = '" +type +"';";
                        SQLiteCommand command = new SQLiteCommand(sql, conn);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        SQLiteDataReader data = command.ExecuteReader();

                        machineCombo.Items.Clear();

                        while (data.Read())
                        {
                            machineCombo.Items.Add(data.GetValue(0));
                        }
                        machineCombo.SelectedIndex = 0;

                    }
                    catch
                    {
                        Form ajout = new AjouterMachine("",machine,false);
                        ajout.Text = "Ajouter votre premiere machine de " + type;
                        ajout.ShowDialog();


                    }
                    conn.Close();

                        }
                else
                {


                    conn.Close();


                }

                CompNum.Text = DBHelper.SelectComponentNumber(selected_component, selected_machine);
                SelectMachineNumber(type);
                DBHelper.FillHomeGrid(metroGrid1,
                 selected_component,
                 selected_machine);

            }
        }
        private void Tri_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "Triage";

            NC.BackColor = System.Drawing.Color.Transparent;
            Tri.BackColor = System.Drawing.Color.LightGray;

            selectMachines(this.Controls["Syn_types"].Controls["Tri"].Text);
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string name = metroGrid1.SelectedRows[0].Cells[1].Value.ToString(), refn = metroGrid1.SelectedRows[0].Cells[2].Value.ToString(),
                modif = metroGrid1.SelectedRows[0].Cells[4].Value.ToString()
                ,id =  metroGrid1.SelectedRows[0].Cells[0].Value.ToString()
                , inst = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();

            int num_modif = int.Parse(metroGrid1.SelectedRows[0].Cells[6].Value.ToString());


            Component comp = new Component(name, refn, DateTime.Parse(inst), DateTime.Parse(modif),num_modif);
            comp.ID = int.Parse(id);
            comp.Type = selected_component;
            ;
            Modifier_composant modifier = null;

            try
            {
                modifier = new Modifier_composant(comp);
                modifier.cap_Changed += CapChanged;
                modifier.ShowDialog();

            }
           
            catch(Exception ep)
            {
                MessageBox.Show("Le format de date n'est pas accepté");

            }

            
        }

        public void CapChanged(object sender, EventArgs e)
        {
            DBHelper.FillHomeGrid(metroGrid1,
                 selected_component,
                 selected_machine);

        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uneMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Ajout_button_Click(object sender, EventArgs e)
        {
             ajouter_machine = new AjouterMachine("",10,false);

            ajouter_machine.ShowDialog();
        }

        private void modif_button_Click(object sender, EventArgs e)
        {

            new ListDesMachine(ListDesMachine.Edit).ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            new ListDesMachine(ListDesMachine.Del).ShowDialog();

        }

        public void SelectComponentNumber( )
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {

                    if (Equals(selected_component, "Vérin")){
                        selected_component = "verin";
                    }

                    connection.Open();

                    string composants_num = "select"+
                               " count(id_machine) as counts from "+selected_component+" inner join machine on id_machine ="+
                                "machine.id  where machine.nom = '"+selected_machine+"'; ";

                    SQLiteCommand cmd = new SQLiteCommand(composants_num, connection);

                    CompNum.Text =  cmd.ExecuteScalar().ToString();

                  

                }
                else
                {
                    connection.Close();

                }

            }


        }

        public void SelectMachineNumber(string type)
        {

            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {

                    if (Equals(selected_component, "Vérins"))
                    {
                        selected_component = "verin";
                    }

                    connection.Open();

                    string composants_num = "select" +
                               " count(id) as counts from machine where machine.type = '"+type+"'; ";

                    SQLiteCommand cmd = new SQLiteCommand(composants_num, connection);

                    MacNum.Text = machineCombo.Items.Count.ToString();



                }
                else
                {
                    connection.Close();

                }

            }



        }
        private void machineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_machine = machineCombo.SelectedItem.ToString();

            if (selected_component != null)
            {
                DBHelper.FillHomeGrid(metroGrid1,
                                selected_component,
                                selected_machine);
                try
                {
                    CompNum.Text = DBHelper.SelectComponentNumber(selected_component, selected_machine);
                    SelectMachineNumber(SelectedMachineType);


                }
                catch (Exception)
                {

                    throw;
                }       
                

            }
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            Synth_Click(this, e);
            DBHelper.FillHomeGrid(metroGrid1,
                caps.SelectedItem.ToString().Substring(0, caps.SelectedItem.ToString().Length - 1),
                selected_machine);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MacName_TextChanged(object sender, EventArgs e)

        {
            string component = "";
            int comp = caps.SelectedIndex;

            string machine = machineCombo.SelectedItem.ToString();

            using(SQLiteConnection connection =new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {

                switch (comp)
                {
                    case 0:
                        component = "capteur";
                        break;
                    case 1:
                        component = "moteur";

                        break;
                    case 2:
                        component = "reducteur";

                        break;
                    case 3:
                        component = "verin";

                        break;
                    case 4:
                        component = "courroie";

                        break;
                }

                

               
                string command = "select "+component+".nom , "+ component +".reference ," +
                    component+".date_insertion as \"date d'insertion\", "+ component+".date_modification as \"de modification\" ," +
                    component+".life_duration as \"durée de vie\" from " + component+" inner join "+component+" on machine.id = "
                    +component+".id_machine  where machine.nom = "+machine
                    + " and ("+component+".nom = "+Search.Text+" or "+ component +".reference = "+Search.Text+");";

                if (Equals(component, "verin"))
                {

                    command = "select nom , reference , deriner_vidange as \"dernier vidange\"" +
                        ", huile_durée as \"huile longevité\" from verin full join machine on machine.id=verin.id_machine where machine.nom = " + machine + ";";

                }

                connection.Open();

                metroGrid1.Refresh();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                metroGrid1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void ProfileButton_Click_1(object sender, EventArgs e)
        {
            new ListDesMachine(ListDesMachine.Con).ShowDialog();

        }

        private void expand_AnimationFinished(object sender, EventArgs e)
        {
            panel1.Width = 421;
            MenuButton.Dock = DockStyle.None;
            MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MenuButton.Padding = new System.Windows.Forms.Padding(0);
            modif_button.IconSize = 48;
            Ajout_button.IconSize = 48;
            Ajout_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            modif_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            Synth.IconSize = 140;
            Tecnoferrari.IconSize = 140;
            Banc.IconSize = 140;
            CPK.IconSize = 140;
            accoppiatore.IconSize = 140;
            Palettiseur.IconSize = 140;

            foreach (IconButton button in panel1.Controls.OfType<IconButton>())
            {
                button.Text = button.Tag.ToString();
                button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);

                pictureBox1.Visible = true;

            }
        }

        private void collapse_AnimationFinished(object sender, EventArgs e)
        {
            panel1.Width = 102;
            MenuButton.Dock = DockStyle.Top;
            MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MenuButton.Padding = new System.Windows.Forms.Padding(0);
            modif_button.IconSize = 70;
            Ajout_button.IconSize = 70;
            Synth.IconSize = 70;
            Tecnoferrari.IconSize = 70;
            Banc.IconSize = 70;
            CPK.IconSize = 70;
            accoppiatore.IconSize = 70;
            Palettiseur.IconSize = 70;



            foreach (IconButton button in panel1.Controls.OfType<IconButton>())
            {
                button.Text = "";
                button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                button.Padding = new System.Windows.Forms.Padding(8);
                pictureBox1.Visible = false;

            }
        }

        private void Tecnoferrari_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "Tecno-ferrari";

            if (Syn_types.Visible)
            {
                Syn_types.Visible = false;

            }
            Tecnoferrari.BackColor = System.Drawing.Color.LightGray;

            Synth.BackColor = System.Drawing.Color.Transparent;
            Banc.BackColor = System.Drawing.Color.Transparent;
            accoppiatore.BackColor = System.Drawing.Color.Transparent;
            Palettiseur.BackColor = System.Drawing.Color.Transparent;
            CPK.BackColor = System.Drawing.Color.Transparent;
            selectMachines(SelectedMachineType);




        }

        private void Banc_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "Banc";

            if (Syn_types.Visible)
            {
                Syn_types.Visible = false;

            }

            Banc.BackColor = System.Drawing.Color.LightGray;

            Synth.BackColor = System.Drawing.Color.Transparent;
            Tecnoferrari.BackColor = System.Drawing.Color.Transparent;
            accoppiatore.BackColor = System.Drawing.Color.Transparent;
            Palettiseur.BackColor = System.Drawing.Color.Transparent;
            CPK.BackColor = System.Drawing.Color.Transparent;
            selectMachines(SelectedMachineType);
        }

        private void CPK_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "CPK";

            if (Syn_types.Visible)
            {
                Syn_types.Visible = false;

            }
            CPK.BackColor = System.Drawing.Color.LightGray;

            Synth.BackColor = System.Drawing.Color.Transparent;
            Banc.BackColor = System.Drawing.Color.Transparent;
            accoppiatore.BackColor = System.Drawing.Color.Transparent;
            Palettiseur.BackColor = System.Drawing.Color.Transparent;
            Tecnoferrari.BackColor = System.Drawing.Color.Transparent;
            selectMachines(SelectedMachineType);
        }

        private void accoppiatore_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "Accoppiatore";

            if (Syn_types.Visible)
            {
                Syn_types.Visible = false;

            }
            accoppiatore.BackColor = System.Drawing.Color.LightGray;

            Synth.BackColor = System.Drawing.Color.Transparent;
            Banc.BackColor = System.Drawing.Color.Transparent;
            Tecnoferrari.BackColor = System.Drawing.Color.Transparent;
            Palettiseur.BackColor = System.Drawing.Color.Transparent;
            CPK.BackColor = System.Drawing.Color.Transparent;
            selectMachines(SelectedMachineType);
        }

        private void Palettiseur_Click(object sender, EventArgs e)
        {
            SelectedMachineType = "Palettiseur";


            Syn_types.Controls["Tri"].Text = "Maxi-pack";
            Syn_types.Controls["NC"].Text = "Extra-pack";
            IconButton c = (IconButton)Syn_types.Controls["NC"];
            IconButton s = (IconButton)Syn_types.Controls["Tri"];

            c.IconChar = IconChar.Perbyte;
            s.IconChar = IconChar.Perbyte;


            zeroitAnimatorEdit1.Activate();


            Palettiseur.BackColor = System.Drawing.Color.LightGray;

            Synth.BackColor = System.Drawing.Color.Transparent;
            Banc.BackColor = System.Drawing.Color.Transparent;
            accoppiatore.BackColor = System.Drawing.Color.Transparent;
            Tecnoferrari.BackColor = System.Drawing.Color.Transparent;
            CPK.BackColor = System.Drawing.Color.Transparent;
            selectMachines(c.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            SelectedMachineType = "New-check";

            Tri.BackColor = System.Drawing.Color.Transparent;
            NC.BackColor = System.Drawing.Color.LightGray;

            selectMachines(this.Controls["Syn_types"].Controls["NC"].Text);
        }

        private void guna2ComboBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PdfPTable table = new PdfPTable(metroGrid1.ColumnCount);
            PdfPCell pdfPCell = null;
            Chunk glue = new Chunk(new VerticalPositionMark());

            Document document = new Document(PageSize.A4,0f,0f,0f,0f);
            document.SetMargins(20f, 20f, 20f, 20f);

            string id = Guid.NewGuid().ToString();

            string path = AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".pdf";


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            document.Open();

            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            iTextSharp.text.Font FS = FontFactory.GetFont("Calibri",12,iTextSharp.text.Font.BOLD,
            BaseColor.BLACK);



            iTextSharp.text.Paragraph lineSeparator = new iTextSharp.text.Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator
                (0.0F, 100.0F, BaseColor.BLACK,
                Element.ALIGN_LEFT, 1)));

            document.Add(lineSeparator);

            document.Add(new iTextSharp.text.Paragraph(""));
            iTextSharp.text.Image picture = iTextSharp.text.Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + "\\Logo.png");

            picture.ScaleToFit(80f, 80f);
            picture.Alignment = Element.ALIGN_LEFT;
            picture.SpacingAfter = 1;

            document.Add(picture);

            document.Add(new Phrase("\t     MacDoc", FS));

            document.Add(lineSeparator);

            document.Add(new iTextSharp.text.Paragraph(""));


     

            document.Add(new iTextSharp.text.Paragraph("\n"));

            document.Add(new Phrase("Redigé le: " + DateTime.Now, FS));

            document.Add(lineSeparator);

            document.Add(new iTextSharp.text.Paragraph("\n"));

            document.Add(new Phrase("Executant: " + "Aymen", FS));


            document.Add(lineSeparator);

            document.Add(new iTextSharp.text.Paragraph("\n"));


            Chunk machineTitle = new Chunk(machineCombo.SelectedItem.ToString(), FS);

            Phrase machine_phrase = new Phrase();
            Chunk machineT = new Chunk("Machine: ", FS);

            machine_phrase.Add(machineT);

            FS = FontFactory.GetFont("Calibri", 10, 
            BaseColor.BLACK);

            machine_phrase.Add(new Chunk(machineCombo.SelectedItem.ToString(), FS));

            machine_phrase.Add(glue);

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
            BaseColor.BLACK);

            Chunk reference = new Chunk("Reference: ", FS);

            machine_phrase.Add(reference);

            FS = FontFactory.GetFont("Calibri", 10,
          BaseColor.BLACK);

            machine_phrase.Add(new Chunk("ORITNF000", FS));



            document.Add(machine_phrase);

            document.Add(new iTextSharp.text.Paragraph("\n"));

            Phrase machineType = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk macType = new Chunk("Machine type: ", FS);
            machineType.Add(macType);

            FS = FontFactory.GetFont("Calibri", 10, 
         BaseColor.BLACK);

             macType = new Chunk(SelectedMachineType, FS);

            machineType.Add(macType);


            document.Add(machineType);



            Phrase CompoType = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk CType = new Chunk("Composants: ", FS);

            CompoType.Add(CType);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            CType = new Chunk(Composants.Text, FS);

            CompoType.Add(CType);

            document.Add(new iTextSharp.text.Paragraph("\n"));

            document.Add(CompoType);

            document.Add(new iTextSharp.text.Paragraph("\n"));


            //table.SetWidths(new float[] { 20f, 150f, 100f});

            #region Write table


            FS = FontFactory.GetFont("Calibri", 10,
           BaseColor.BLACK);

            foreach (DataGridViewColumn header in metroGrid1.Columns)
            {

                pdfPCell = new PdfPCell(new Phrase(header.HeaderText, FS));
                pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(pdfPCell);

            }

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                foreach (DataGridViewCell column in row.Cells)
                {

                    pdfPCell = new PdfPCell(new Phrase(column.Value.ToString(), FS));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(pdfPCell);

                }
            }

            #endregion



            document.Add(new iTextSharp.text.Paragraph("\n"));


            Phrase phrase = new Phrase("Responsable: ", FS);
            phrase.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator
                (0.0F, 40.0F, BaseColor.BLACK,
                Element.ALIGN_LEFT, 1)));

           

            document.Add(table);

            document.Add(new iTextSharp.text.Paragraph("\n"));
            document.Add(new iTextSharp.text.Paragraph(""));


            document.Add(phrase);

            document.Close();

        
                System.Diagnostics.Process.Start(path);
            


        }

        private void MacNum_Click(object sender, EventArgs e)
        {

        }
  
    }
}
