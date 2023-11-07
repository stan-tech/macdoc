using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace macdoc
{
    public partial class Store : Form
    {
        bool ButtonCreated = false;
        string SelectedComponent = "";
        bool isDragged = false;
        Point ptOffset;
        RoundedButton btn;
        int Operation;
        string state = "Nouveau";

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

        public Store()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height,90, 90));

            ControlExtension.Draggable(this,true);
            foreach (Control b in MainPanel.Controls)
            {
                if (b is RoundedButton)
                {
                    ControlExtension.Draggable(b, true);


                }
            }
        }

        private async void Store_Load(object sender, EventArgs e)
        {
            Task.Run(() => { caps.Invoke((MethodInvoker)(() =>
            { caps.SelectedIndex = 0; })); }); 


        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {


        }



     

        private async void Ajouter_Click(object sender, EventArgs e)
        {
            
            if (SelectedComponent == "")
            {
                MessageBox.Show("Selectionner un composant d'abbord", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
            }
            
        }


        

        private void Cancel_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }

        private void Store_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void Retirer_Click(object sender, EventArgs e)
        {
        //    Qt.Focus();
        //    Qt.SelectAll();
        //    Operation = 0;

        }

        

        private void Compos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* switch(Compos.SelectedRows[0].Cells[0].Value.ToString()){

                 case "Capteur" :

                     Ajouter.Text = "Retirer des capteurs";
                     break;
                 case "Reducteur":

                     Ajouter.Text = "Retirer des reducteurs";
                     break;
                 case "Moteur":

                     Ajouter.Text = "Retirer des moteurs";
                     break;
                 case "Courroie":

                     Ajouter.Text = "Retirer des courroies";
                     break;
                 case "Huile":

                     Ajouter.Text = "Retirer d'huile";

                     break;

             }*/
            contextMenuStrip1.Show(Cursor.Position);
          



        }


        private void Ajout_menu_click(object sender, EventArgs e)
        {
            new Arrivage(SelectedComponent,true).ShowDialog();

            //Qt.Focus();
            //Qt.SelectAll();
            //Operation = 1;
        }

        private void Compos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedComponent = Compos.SelectedRows[0].Cells[0].Value.ToString();

            contextMenuStrip1.Show(Cursor.Position);
            //price.Text = Compos.SelectedRows[0].Cells[2].Value.ToString();
            //SelectedComponent = Compos.SelectedRows[0].Cells[0].Value.ToString();

            //Qt.Focus();
            //Qt.SelectAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void Added(object sender, EventArgs e)
        {



            try
            {
                Compos.DataSource = await DBHelper.FillStoreGrid(state);

            }
            catch (Exception)
            {

                throw;
            }
           

        }
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Arrivage arrivage = new Arrivage(SelectedComponent,true);
            arrivage.added += Added;

            arrivage.ShowDialog();


        }

        private void bilans_Click(object sender, EventArgs e)
        {
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            BuyHistory history = new BuyHistory();
            history.ShowDialog();
            this.Close();


        }

        private void caps_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Composants_Click(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            GeneratePdf(Compos);
        }
        public void GeneratePdf(MetroGrid grid)
        {
            PdfPTable table = new PdfPTable(grid.ColumnCount);
            PdfPCell pdfPCell = null;
            Chunk glue = new Chunk(new VerticalPositionMark());

            Document document = new Document(PageSize.A4, 0f, 0f, 0f, 0f);
            document.SetMargins(20f, 20f, 20f, 20f);

            string id = Guid.NewGuid().ToString();

            string path = AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".pdf";


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            document.Open();

            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            iTextSharp.text.Font FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
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

            Phrase machineType = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk macType = new Chunk("Type de document: ", FS);
            machineType.Add(macType);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            switch (state)
            {
                case "Nouveau":
                    macType = new Chunk("liste des nouveaux composants.", FS);

                    break;
                case "Replaced":

                    macType = new Chunk("liste des composants remplacés.", FS);

                    break;
                case "InUse":

                    macType = new Chunk("liste des composants en usage.", FS);

                    break;
            }

            machineType.Add(macType);


            document.Add(machineType);

            document.Add(new iTextSharp.text.Paragraph("\n"));


            //table.SetWidths(new float[] { 20f, 150f, 100f});

            #region Write table


            FS = FontFactory.GetFont("Calibri", 10,
           BaseColor.BLACK);

            foreach (DataGridViewColumn header in grid.Columns)
            {

                pdfPCell = new PdfPCell(new Phrase(header.HeaderText, FS));
                pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(pdfPCell);

            }

            foreach (DataGridViewRow row in grid.Rows)
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

        private async void caps_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (caps.SelectedIndex)
            {
                case 0:

                    state = "Nouveau";

                    break;
                case 1:
                    state = "InUse";
                    break;
                case 2:
                    state = "Replaced";
                    break;
            }


            Compos.DataSource = await DBHelper.FillStoreGrid(state);
        }
    }
}
