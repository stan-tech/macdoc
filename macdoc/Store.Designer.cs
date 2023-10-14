namespace macdoc
{
    partial class Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Composants = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.Retirer = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Compos = new MetroFramework.Controls.MetroGrid();
            this.AjouCour = new macdoc.RoundedButton();
            this.ajouver = new macdoc.RoundedButton();
            this.Ajoured = new macdoc.RoundedButton();
            this.Ajoumot = new macdoc.RoundedButton();
            this.Ajout_cap = new macdoc.RoundedButton();
            this.roundedButton3 = new macdoc.RoundedButton();
            this.Cancel = new macdoc.RoundedButton();
            this.roundedButton2 = new macdoc.RoundedButton();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.Ajouter = new macdoc.RoundedButton();
            this.price = new macdoc.RoundedTextBox();
            this.Qt = new macdoc.RoundedTextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.SuspendLayout();
            // 
            // caps
            // 
            this.caps.BackColor = System.Drawing.Color.Transparent;
            this.caps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.caps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caps.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.caps.ItemHeight = 30;
            this.caps.Items.AddRange(new object[] {
            "Nom ",
            "Quantité",
            "Prix"});
            this.caps.Location = new System.Drawing.Point(1525, 92);
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size(317, 36);
            this.caps.TabIndex = 50;
            // 
            // Composants
            // 
            this.Composants.AutoSize = true;
            this.Composants.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Composants.ForeColor = System.Drawing.Color.White;
            this.Composants.Location = new System.Drawing.Point(1517, 24);
            this.Composants.Name = "Composants";
            this.Composants.Size = new System.Drawing.Size(149, 45);
            this.Composants.TabIndex = 56;
            this.Composants.Text = "Trier par";
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.roundedButton3);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.roundedButton2);
            this.panel1.Controls.Add(this.roundedButton1);
            this.panel1.Controls.Add(this.Ajouter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.Qt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 180);
            this.panel1.TabIndex = 57;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Annuler,
            this.Retirer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(343, 84);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Orange;
            this.Annuler.Image = ((System.Drawing.Image)(resources.GetObject("Annuler.Image")));
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(342, 40);
            this.Annuler.Text = "Annuler";
            // 
            // Retirer
            // 
            this.Retirer.BackColor = System.Drawing.Color.Orange;
            this.Retirer.Image = ((System.Drawing.Image)(resources.GetObject("Retirer.Image")));
            this.Retirer.Name = "Retirer";
            this.Retirer.Size = new System.Drawing.Size(342, 40);
            this.Retirer.Text = "Retirer un composant";
            this.Retirer.Click += new System.EventHandler(this.Retirer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(568, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 45);
            this.label3.TabIndex = 56;
            this.label3.Text = "DZD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(414, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 45);
            this.label2.TabIndex = 56;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quantité";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AjouCour);
            this.MainPanel.Controls.Add(this.ajouver);
            this.MainPanel.Controls.Add(this.Ajoured);
            this.MainPanel.Controls.Add(this.Ajoumot);
            this.MainPanel.Controls.Add(this.Ajout_cap);
            this.MainPanel.Controls.Add(this.Compos);
            this.MainPanel.Location = new System.Drawing.Point(1, 199);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1844, 710);
            this.MainPanel.TabIndex = 58;
            // 
            // Compos
            // 
            this.Compos.AllowDrop = true;
            this.Compos.AllowUserToAddRows = false;
            this.Compos.AllowUserToDeleteRows = false;
            this.Compos.AllowUserToOrderColumns = true;
            this.Compos.AllowUserToResizeColumns = false;
            this.Compos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            this.Compos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Compos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Compos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Compos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Compos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Compos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Compos.ColumnHeadersHeight = 57;
            this.Compos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.DefaultCellStyle = dataGridViewCellStyle13;
            this.Compos.EnableHeadersVisualStyles = false;
            this.Compos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Compos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.Location = new System.Drawing.Point(432, 6);
            this.Compos.Name = "Compos";
            this.Compos.ReadOnly = true;
            this.Compos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Compos.RowHeadersWidth = 82;
            this.Compos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(41);
            this.Compos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Compos.RowTemplate.Height = 130;
            this.Compos.RowTemplate.ReadOnly = true;
            this.Compos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Compos.Size = new System.Drawing.Size(1409, 690);
            this.Compos.Style = MetroFramework.MetroColorStyle.Silver;
            this.Compos.TabIndex = 59;
            this.Compos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Compos_CellMouseDoubleClick);
            // 
            // AjouCour
            // 
            this.AjouCour.BackColor = System.Drawing.Color.Teal;
            this.AjouCour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouCour.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouCour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AjouCour.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.AjouCour.IconColor = System.Drawing.Color.WhiteSmoke;
            this.AjouCour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AjouCour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouCour.Location = new System.Drawing.Point(15, 594);
            this.AjouCour.Name = "AjouCour";
            this.AjouCour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AjouCour.Size = new System.Drawing.Size(369, 92);
            this.AjouCour.TabIndex = 61;
            this.AjouCour.Tag = "Ajouter une machine";
            this.AjouCour.Text = "Acheter des courroies";
            this.AjouCour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouCour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AjouCour.UseVisualStyleBackColor = false;
            this.AjouCour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AjouCour_MouseMove);
            this.AjouCour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AjouCour_MouseUp);
            // 
            // ajouver
            // 
            this.ajouver.BackColor = System.Drawing.Color.Teal;
            this.ajouver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouver.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ajouver.IconChar = FontAwesome.Sharp.IconChar.OilCan;
            this.ajouver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ajouver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ajouver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouver.Location = new System.Drawing.Point(15, 444);
            this.ajouver.Name = "ajouver";
            this.ajouver.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ajouver.Size = new System.Drawing.Size(369, 92);
            this.ajouver.TabIndex = 62;
            this.ajouver.Tag = "Ajouter une machine";
            this.ajouver.Text = "Acheter d\'huile ";
            this.ajouver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajouver.UseVisualStyleBackColor = false;
            this.ajouver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ajouver_MouseMove);
            this.ajouver.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ajouver_MouseUp);
            // 
            // Ajoured
            // 
            this.Ajoured.BackColor = System.Drawing.Color.Teal;
            this.Ajoured.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajoured.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajoured.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajoured.IconChar = FontAwesome.Sharp.IconChar.Timeline;
            this.Ajoured.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajoured.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajoured.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoured.Location = new System.Drawing.Point(15, 297);
            this.Ajoured.Name = "Ajoured";
            this.Ajoured.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajoured.Size = new System.Drawing.Size(369, 92);
            this.Ajoured.TabIndex = 63;
            this.Ajoured.Tag = "Ajouter une machine";
            this.Ajoured.Text = "Acheter des reducteurs";
            this.Ajoured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoured.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoured.UseVisualStyleBackColor = false;
            this.Ajoured.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ajoured_MouseMove);
            this.Ajoured.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ajoured_MouseUp);
            // 
            // Ajoumot
            // 
            this.Ajoumot.BackColor = System.Drawing.Color.Teal;
            this.Ajoumot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajoumot.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajoumot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajoumot.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.Ajoumot.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajoumot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajoumot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoumot.Location = new System.Drawing.Point(15, 149);
            this.Ajoumot.Name = "Ajoumot";
            this.Ajoumot.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajoumot.Size = new System.Drawing.Size(369, 92);
            this.Ajoumot.TabIndex = 64;
            this.Ajoumot.Tag = "Ajouter un moteur";
            this.Ajoumot.Text = "Acheter des moteurs";
            this.Ajoumot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoumot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoumot.UseVisualStyleBackColor = false;
            this.Ajoumot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ajoumot_MouseMove);
            this.Ajoumot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ajoumot_MouseUp);
            // 
            // Ajout_cap
            // 
            this.Ajout_cap.BackColor = System.Drawing.Color.Teal;
            this.Ajout_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajout_cap.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_cap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_cap.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.Ajout_cap.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_cap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajout_cap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_cap.Location = new System.Drawing.Point(15, 4);
            this.Ajout_cap.Name = "Ajout_cap";
            this.Ajout_cap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajout_cap.Size = new System.Drawing.Size(369, 92);
            this.Ajout_cap.TabIndex = 65;
            this.Ajout_cap.Tag = "Ajouter une machine";
            this.Ajout_cap.Text = "Acheter des capteurs";
            this.Ajout_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_cap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_cap.UseVisualStyleBackColor = false;
            this.Ajout_cap.DragDrop += new System.Windows.Forms.DragEventHandler(this.Ajout_button_DragDrop);
            this.Ajout_cap.DragOver += new System.Windows.Forms.DragEventHandler(this.Ajout_button_DragOver);
            this.Ajout_cap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ajout_button_MouseDown);
            this.Ajout_cap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ajout_button_MouseMove);
            this.Ajout_cap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ajout_button_MouseUp);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.roundedButton3.IconColor = System.Drawing.Color.Black;
            this.roundedButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton3.IconSize = 38;
            this.roundedButton3.Location = new System.Drawing.Point(1, 58);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(15);
            this.roundedButton3.Size = new System.Drawing.Size(60, 58);
            this.roundedButton3.TabIndex = 57;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Orange;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.Cancel.IconColor = System.Drawing.Color.Black;
            this.Cancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Cancel.IconSize = 38;
            this.Cancel.Location = new System.Drawing.Point(1102, 58);
            this.Cancel.Name = "Cancel";
            this.Cancel.Padding = new System.Windows.Forms.Padding(15);
            this.Cancel.Size = new System.Drawing.Size(60, 58);
            this.Cancel.TabIndex = 57;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.roundedButton2.IconColor = System.Drawing.Color.Black;
            this.roundedButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton2.IconSize = 38;
            this.roundedButton2.Location = new System.Drawing.Point(304, 58);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(15);
            this.roundedButton2.Size = new System.Drawing.Size(60, 58);
            this.roundedButton2.TabIndex = 57;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.Black;
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.roundedButton1.IconColor = System.Drawing.Color.Black;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(1220, 58);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.roundedButton1.Size = new System.Drawing.Size(276, 58);
            this.roundedButton1.TabIndex = 56;
            this.roundedButton1.Tag = "Ajouter une machine";
            this.roundedButton1.Text = "Changer le prix";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.Black;
            this.Ajouter.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Ajouter.IconColor = System.Drawing.Color.Black;
            this.Ajouter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(653, 58);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Ajouter.Size = new System.Drawing.Size(443, 58);
            this.Ajouter.TabIndex = 56;
            this.Ajouter.Tag = "Ajouter ";
            this.Ajouter.Text = "Ajouter un composant";
            this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // price
            // 
            this.price.Animated = true;
            this.price.ContextMenuStrip = this.contextMenuStrip1;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(372, 62);
            this.price.Margin = new System.Windows.Forms.Padding(5);
            this.price.Name = "price";
            this.price.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.price.PasswordChar = '\0';
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(192, 50);
            this.price.TabIndex = 42;
            this.price.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // Qt
            // 
            this.Qt.Animated = true;
            this.Qt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qt.DefaultText = "00.00";
            this.Qt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Qt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Qt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qt.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qt.ForeColor = System.Drawing.Color.Black;
            this.Qt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qt.Location = new System.Drawing.Point(69, 62);
            this.Qt.Margin = new System.Windows.Forms.Padding(5);
            this.Qt.Name = "Qt";
            this.Qt.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Qt.PasswordChar = '\0';
            this.Qt.PlaceholderText = "";
            this.Qt.SelectedText = "";
            this.Qt.Size = new System.Drawing.Size(227, 50);
            this.Qt.TabIndex = 42;
            this.Qt.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1857, 909);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Composants);
            this.Controls.Add(this.caps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Store_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        private System.Windows.Forms.Label Composants;
        private System.Windows.Forms.Panel panel1;
        public RoundedTextBox Qt;
        public RoundedTextBox price;
        private RoundedButton Ajouter;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton2;
        private System.Windows.Forms.Panel MainPanel;
        public MetroFramework.Controls.MetroGrid Compos;
        private RoundedButton AjouCour;
        private RoundedButton ajouver;
        private RoundedButton Ajoured;
        private RoundedButton Ajoumot;
        private RoundedButton Ajout_cap;
        private RoundedButton Cancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Annuler;
        private System.Windows.Forms.ToolStripMenuItem Retirer;
    }
}