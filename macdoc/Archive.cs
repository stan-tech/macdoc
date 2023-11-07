using ClosedXML.Excel;
using Guna.UI2.WinForms;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MetroFramework.Controls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Web.ReportDesigner.DataContracts;

namespace macdoc
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        string orderBy = string.Empty;
        string machine_id = string.Empty;
        string user = string.Empty;
        string limit = string.Empty;
        bool mouseClicked = false;
        int direction = 0;
        int ModifgridHeight;
        int MachinegridHeight;
        const int MaxHeight = 1034;
        const int MinHeight = 615;
        bool keepGoing;
        bool PanelShown = false;
        Timer t = new Timer();
        MetroGrid AllModificationsTable = new MetroGrid();
        MetroGrid VarTable = new MetroGrid();
        string Selectedcomponents, modifier, lines;
        string machineName = "Tout";
        string machineRef = "Tout", machineType = "Tout";

        private void Archive_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            TrierPar.SelectedIndex = 0;



        }

        private void Archive_Shown(object sender, EventArgs e)
        {
            Limit.SelectedIndex = 0;
            Type.SelectedIndex = 0;
            Components.SelectedIndex = 0;
            Guna2ComboBox modifcateurs = new Guna2ComboBox();
            Task.Run( () =>
            {

                DBHelper.SelectAllUsers(Modificateurs);

            });


            limit = Limit.SelectedItem.ToString();

           // Modificateurs.SelectedIndex = 0;

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBHelper.SelectMachineByType(metroGrid1, Type.SelectedItem.ToString());
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void TrierPar_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (TrierPar.SelectedItem.ToString())
            {

                case "Nom du composant":

                    orderBy = "component.nom";
                    break;
                case "Date ascendante":
                    orderBy = "component.date_modification asc";
                    break;
                case "Date descendante":
                    orderBy = "component.date_modification desc";
                    break;

            }

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {

                Modifs.DataSource 
                    = await DBHelper.FillArchiveModifications( orderBy, machine_id, "Tout", "Tout", "Tout");
                AllModificationsTable = Modifs;

                Selectedcomponents = "Tout";
                modifier = "Tout"; 
                lines = "Tout";


            }
            else
            {
                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);
                VarTable = Modifs;
                Selectedcomponents = Components.SelectedItem.ToString();
                modifier = user;
                lines = limit;

            }
        }




        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectModifications();
        }

        public async void SelectModifications()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                connection.Open();
                try
                {
                    machine_id = new SQLiteCommand("select id from machine where reference = '" + metroGrid1.SelectedRows[0].Cells[2].Value.ToString()
                           + "';", connection).ExecuteScalar().ToString();

                    SQLiteDataReader reader  = new SQLiteCommand("select nom,reference,type from machine where id = '" + machine_id
                           + "';", connection).ExecuteReader();
                    if(reader.Read())
                    {
                        machineName = reader.GetString(0);
                        machineRef = reader.GetString(1);
                        machineType = reader.GetString(2);
                    }

                    reader.Close();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection.Close();

                }


            }

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                Modifs.DataSource =AllModificationsTable.DataSource
                    = await DBHelper.FillArchiveModifications(orderBy, machine_id, "Tout", "Tout", "Tout");

                Selectedcomponents = "Tout";
                modifier = "Tout";
                lines = "Tout";
            }
            else
            {
                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);
                VarTable = Modifs;
                Selectedcomponents = Components.SelectedItem.ToString();
                modifier = user;
                lines = limit;
            }
        }
        private async void SearchModif_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {






                string command = "select machine.nom as machine, component.type , component.nom as nom, component.reference, users.nom as modificateur , date_modification as \"derniére modification\" , notes from modification inner join component" +
                           " on modification.id_composant = component.id  inner join users on users.id = component.modificateur inner join machine on  component.id_machine = machine.id where "
                    + " (component.nom like '" + SearchModif.Text.Trim() + "%' or component .reference like '" + SearchModif.Text.Trim() + "%' or notes like  '%" +
                    SearchModif.Text + "%') ;";


                connection.Open();

                try
                {
                    if (!Equals(SearchModif.Text, string.Empty))
                    {
                        Modifs.Refresh();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Modifs.DataSource = dataTable;
                    }
                    else
                    {
                        Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Echec !" + ex.Message, "Ajout", MessageBoxButtons.OK);

                }
                connection.Close();
            }
        }

        private async void Componenets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {

                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, "Tout", "Tout", "Tout");
                Selectedcomponents = "Tout";
                modifier = "Tout";
                lines = "Tout";
            }
            else
            {
                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);
                VarTable = Modifs;
                Selectedcomponents = Components.SelectedItem.ToString();
                modifier = user;
                lines = limit;
           

            }
        }

        private async void Modificateurs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, "Tout", "Tout", "Tout");

                Selectedcomponents = "Tout";
                modifier = "Tout";
                lines = "Tout";
            }
            else
            {
                user = Modificateurs.SelectedItem.ToString();

                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);
                VarTable = Modifs;
                Selectedcomponents = Components.SelectedItem.ToString();
                modifier = user;
                lines = limit;
            }
        }

        private async void Limit_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Components.SelectedItem == null || TrierPar.SelectedItem == null ||
                Modificateurs.SelectedItem == null || Limit.SelectedItem == null)
            {
                Modifs.DataSource = await DBHelper.FillArchiveModifications(orderBy, machine_id, "Tout", "Tout", "Tout");
                Selectedcomponents = "Tout";
                modifier = "Tout";
                lines = "Tout";

            }
            else
            {
                limit = Limit.SelectedItem.ToString();

                Modifs.DataSource =  await DBHelper.FillArchiveModifications(orderBy, machine_id, Components.SelectedItem.ToString(), user, limit);
                VarTable = Modifs;
                Selectedcomponents = Components.SelectedItem.ToString();
                modifier = user;
                lines = limit;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            direction = e.Y;
            ModifgridHeight = this.panel1.Height;
            MachinegridHeight = this.panel2.Height;



        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {



            if ((panel1.Height < MaxHeight && panel2.Height < MaxHeight) &&
                     (panel1.Height > MinHeight && panel2.Height > MinHeight))
            {
                keepGoing = true;
            }
            else
            {

                keepGoing = false;
            }

            if (mouseClicked)
            {

                if (direction > e.Y)
                {


                    // this.panel1.Height = panel1.Height + (panel2.Height - e.Y);
                    // this.Modifs.Height = Modifs.Height + (Modifs.Height - e.Y);

                    // this.panel2.Height = panel1.Height - (panel2.Bottom - panel1.Top);




                    if (keepGoing)
                    {
                        this.panel1.Top = panel1.Top + e.Y;

                        this.panel1.Height += ModifgridHeight / 50;
                        this.panel2.Height -= MachinegridHeight / 120;

                    }
                    /*
                     machine panel size = (2456, 860)  location (-1, 47)

                        modifs panel size (2443, 879) location (0, 898)

                     */

                }
                else
                {

                    if (keepGoing)
                    {
                        this.panel1.Top = panel1.Top + e.Y;

                        this.panel2.Height += MachinegridHeight / 50;
                        this.panel1.Height -= ModifgridHeight / 120;
                    }

                    //this.panel1.Height = panel1.Height - (panel2.Height - e.Y);
                    //this.Modifs.Height = ModifgridHeight - (ModifgridHeight - e.Y);

                    //this.panel2.Height = panel1.Height + (panel2.Bottom - panel1.Top);
                }

            }
        }

        private void AffichierMachines_Click(object sender, EventArgs e)
        {

            if (!PanelShown)
            {


                //modifCollapse.Activate();
                //machineExpand.Activate();

                panel2.Height = 860;
                panel2.Location = new Point(-1, 47);

                panel1.Height = 839;
                panel1.Location = new Point(0, 898);

                AffichierMachines.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                AffichierMachines.Text = "Masquer les machines";
                PanelShown = true;


            }
            else
            {

                //modifExpand.Activate();
                //machineCollapse.Activate();

                panel2.Height = 10;
                panel2.Location = new Point(-1, 47);

                panel1.Height = 1661;
                panel1.Location = new Point(0, 80);

                AffichierMachines.IconChar = FontAwesome.Sharp.IconChar.Eye;
                AffichierMachines.Text = "Afficher les machines";
                PanelShown = false;



            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectModifications();

        }

        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "xlsx", Type.SelectedItem.ToString(),false);
        }

        private void wordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "docx", Type.SelectedItem.ToString(),false);

        }

        private void pdfToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "pdf", "Tout" , true);

        }

        private void pdfToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GeneratePdf(VarTable, machineName, machineRef, machineType, modifier, "pdf", Selectedcomponents, lines);

        }

        private void excelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GeneratePdf(VarTable, machineName, machineRef, machineType, modifier, "xlsx", Selectedcomponents, lines);

        }

        private void wordToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GeneratePdf(VarTable, machineName, machineRef, machineType, modifier, "docx", Selectedcomponents, lines);

        }

        private void pdfToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GeneratePdf(AllModificationsTable, machineName, machineRef, machineType, modifier, "pdf", Selectedcomponents, lines);

        }

        private void excelToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GeneratePdf(AllModificationsTable, machineName, machineRef, machineType, modifier, "xlsx", Selectedcomponents, lines);

        }

        private void wordToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GeneratePdf(AllModificationsTable, machineName, machineRef, machineType, modifier, "docx", Selectedcomponents, lines);

        }

        private  void SearchMac_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {






                string command = "select nom ,type , reference, date_installation as \"date d'installation\"  from machine" +
                    "  where (nom like '" + SearchMac.Text.Trim() + "%' or reference like '" + SearchMac.Text.Trim() + "%') ;";


                connection.Open();

                try
                {
                    if (!Equals(SearchMac.Text, string.Empty))
                    {
                        Modifs.Refresh();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        metroGrid1.DataSource = dataTable;
                    }
                    else
                    {
                       DBHelper.SelectMachineByType(metroGrid1, Type.SelectedItem.ToString());

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Echec !" + ex.Message, "Ajout", MessageBoxButtons.OK);

                }
                connection.Close();
            }

        }

        private void pDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "pdf", Type.SelectedItem.ToString(),false);
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "pdf", Type.SelectedItem.ToString(),false);

        }

        private void wordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GenerateMachinesDocument(metroGrid1, "docx", "Tout", true);

        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectModifications();

        }
        public void GeneratePdf(MetroGrid grid, string selected_machine,string MachineReference,
            string selected_machineType,string modifier, string file,string Composants,string lines)
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


            #region Header

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

            document.Add(new Phrase("Executant: " + "Steve", FS));


            document.Add(lineSeparator); 
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region Title

            PdfPTable titleTable = new PdfPTable(1);
            
            Phrase title = new Phrase();
            
            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
            BaseColor.BLACK);
            Chunk titleChunk = new Chunk("Liste des modifications", FS);

            title.Add(titleChunk);
            PdfPCell cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Phrase = title;
            titleTable.AddCell(cell);
            document.Add(titleTable);
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region Machine name and reference

            Chunk machineTitle = new Chunk(selected_machine, FontFactory.GetFont("Calibri", 10,
            BaseColor.BLACK));

            Phrase machine_phrase = new Phrase();
            Chunk machineT = new Chunk("Machine: ", FS);

            machine_phrase.Add(machineT);


            machine_phrase.Add(machineTitle);

            machine_phrase.Add(glue);

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
            BaseColor.BLACK);

            Chunk reference = new Chunk("Reference: ", FS);

            machine_phrase.Add(reference);

            FS = FontFactory.GetFont("Calibri", 10,
          BaseColor.BLACK);

            machine_phrase.Add(new Chunk(MachineReference, FS));



            document.Add(machine_phrase); 
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region MachineType
            Phrase machineType = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk macType = new Chunk("Machine type: ", FS);
            machineType.Add(macType);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            macType = new Chunk(selected_machineType, FS);

            machineType.Add(macType);


            document.Add(machineType);

            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));


            #region Components
            Phrase CompoType = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk CType = new Chunk("Composants: ", FS);

            CompoType.Add(CType);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            CType = new Chunk(Composants, FS);

            CompoType.Add(CType);
            document.Add(CompoType); 
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region Modifiers

            Phrase Modificateur = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk ModifChunk = new Chunk("Modificateurs: ", FS);

            Modificateur.Add(ModifChunk);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            ModifChunk = new Chunk(modifier, FS);

            Modificateur.Add(ModifChunk);

            document.Add(Modificateur);

            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region Lines

            Phrase Lines = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk LineChunk = new Chunk("Lignes: ", FS);

            Lines.Add(LineChunk);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            LineChunk = new Chunk(lines, FS);

            Lines.Add(LineChunk);

            document.Add(Lines);

            #endregion

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
            var doc = new Aspose.Words.Document(path);

            switch (file.ToLower())
            {

                case "pdf":

                    System.Diagnostics.Process.Start(path);

                    break;
                case "docx":

                    doc.Save(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".docx");
                    File.Delete(path);
                    System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".docx");


                    break;
                case "xlsx":
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add((DataTable)grid.DataSource, "Composants");
                        workbook.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".xlsx");
                        System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".xlsx");
                    }

                    break;
            }


        }
        public void GenerateMachinesDocument(MetroGrid grid, string file,string machineType,bool all)
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


            #region Header

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

            document.Add(new Phrase("Executant: " + "Steve", FS));


            document.Add(lineSeparator);
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region Title

            PdfPTable titleTable = new PdfPTable(1);

            Phrase title = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
            BaseColor.BLACK);
            Chunk titleChunk = new Chunk("Liste des machines", FS);

            title.Add(titleChunk);
            PdfPCell cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Phrase = title;
            titleTable.AddCell(cell);
            document.Add(titleTable);
            #endregion

            document.Add(new iTextSharp.text.Paragraph("\n"));

            #region MachineType
            Phrase machineTypePhrase = new Phrase();

            FS = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
           BaseColor.BLACK);

            Chunk macType = new Chunk("Machine type: ", FS);
            machineTypePhrase.Add(macType);

            FS = FontFactory.GetFont("Calibri", 10,
         BaseColor.BLACK);

            macType = new Chunk(machineType, FS);

            machineTypePhrase.Add(macType);


            document.Add(machineTypePhrase);

            #endregion

            //table.SetWidths(new float[] { 20f, 150f, 100f});

            #region Write table


            FS = FontFactory.GetFont("Calibri", 10,
           BaseColor.BLACK);

            if (all)
            {
                

                Phrase TypePhrase;
                iTextSharp.text.Font F;
                Chunk machineTypeChunk = new Chunk("Machine type: ", FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
                   BaseColor.BLACK));
                MetroGrid grid1;

                foreach (object item in Type.Items)
                {
                    PdfPTable table1 = new PdfPTable(grid.ColumnCount);
                    table1.WidthPercentage = 100;
                    table1.HorizontalAlignment = Element.ALIGN_LEFT;

                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    TypePhrase = new Phrase();

                    machineTypeChunk = new Chunk("Machine type: ", FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD,
                   BaseColor.BLACK));

                    TypePhrase.Add(machineTypeChunk);

                      
                    F = FontFactory.GetFont("Calibri", 10,
                 BaseColor.BLACK);

                    machineTypeChunk = new Chunk(item.ToString(), FS);

                    TypePhrase.Add(machineTypeChunk);


                    document.Add(TypePhrase);

                    grid1 = grid;

                    DBHelper.SelectMachineByType(grid1, item.ToString());

                    foreach (DataGridViewColumn header in grid1.Columns)
                    {

                        pdfPCell = new PdfPCell(new Phrase(header.HeaderText, F));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table1.AddCell(pdfPCell);

                    }


                    foreach (DataGridViewRow row in grid1.Rows)
                    {
                        foreach (DataGridViewCell column in row.Cells)
                        {

                            pdfPCell = new PdfPCell(new Phrase(column.Value.ToString(), F));
                            pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table1.AddCell(pdfPCell);

                        }
                    }

                    document.Add(table1);

                }
            }
            else
            {
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
                document.Add(table);

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
            var doc = new Aspose.Words.Document(path);

            switch (file.ToLower())
            {

                case "pdf":

                    System.Diagnostics.Process.Start(path);

                    break;
                case "docx":

                    doc.Save(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".docx");
                    File.Delete(path);
                    System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".docx");


                    break;
                case "xlsx":
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add((DataTable)grid.DataSource, "Machine");
                        workbook.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".xlsx");
                        System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "MacDoc_file_" + id + ".xlsx");
                    }

                    break;
            }

        }

    }
}
