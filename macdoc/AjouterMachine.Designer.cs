namespace macdoc
{
    partial class AjouterMachine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterMachine));
            this.Composants = new System.Windows.Forms.Label();
            this.Compos = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Voir = new macdoc.RoundedButton();
            this.Addfile = new macdoc.RoundedButton();
            this.Ref = new macdoc.RoundedTextBox();
            this.CompNum = new macdoc.RoundedLabel();
            this.MacName = new macdoc.RoundedTextBox();
            this.Ok = new macdoc.RoundedButton();
            this.iconButton5 = new macdoc.RoundedButton();
            this.TypeCom = new macdoc.FlatCombo();
            this.AjouCour = new macdoc.RoundedButton();
            this.ajouver = new macdoc.RoundedButton();
            this.Ajoured = new macdoc.RoundedButton();
            this.Ajoumot = new macdoc.RoundedButton();
            this.Ajout_button = new macdoc.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.SuspendLayout();
            // 
            // Composants
            // 
            this.Composants.AutoSize = true;
            this.Composants.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Composants.ForeColor = System.Drawing.Color.White;
            this.Composants.Location = new System.Drawing.Point(416, 389);
            this.Composants.Name = "Composants";
            this.Composants.Size = new System.Drawing.Size(158, 45);
            this.Composants.TabIndex = 30;
            this.Composants.Text = "Capteurs";
            // 
            // Compos
            // 
            this.Compos.AllowDrop = true;
            this.Compos.AllowUserToAddRows = false;
            this.Compos.AllowUserToDeleteRows = false;
            this.Compos.AllowUserToOrderColumns = true;
            this.Compos.AllowUserToResizeColumns = false;
            this.Compos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.Compos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Compos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Compos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Compos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Compos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Compos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Compos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Compos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Compos.EnableHeadersVisualStyles = false;
            this.Compos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Compos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.Location = new System.Drawing.Point(412, 450);
            this.Compos.Name = "Compos";
            this.Compos.ReadOnly = true;
            this.Compos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Compos.RowHeadersWidth = 82;
            this.Compos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Compos.RowTemplate.Height = 33;
            this.Compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Compos.Size = new System.Drawing.Size(1562, 856);
            this.Compos.Style = MetroFramework.MetroColorStyle.Silver;
            this.Compos.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1447, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "Composants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            "Capteurs",
            "Moteurs",
            "Reducteurs",
            "Vérins",
            "Courroies"});
            this.caps.Location = new System.Drawing.Point(1455, 398);
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size(317, 36);
            this.caps.TabIndex = 31;
            this.caps.SelectedIndexChanged += new System.EventHandler(this.caps_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(956, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 45);
            this.label2.TabIndex = 36;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 45);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nom";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(12, 222);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(303, 45);
            this.date.TabIndex = 42;
            this.date.Text = "Date d\'installation";
            // 
            // datepicker
            // 
            this.datepicker.Checked = true;
            this.datepicker.CustomFormat = "dd/MM/yyyy";
            this.datepicker.FillColor = System.Drawing.Color.LightGray;
            this.datepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.datepicker.HoverState.FillColor = System.Drawing.Color.GreenYellow;
            this.datepicker.Location = new System.Drawing.Point(20, 275);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(346, 36);
            this.datepicker.TabIndex = 43;
            this.datepicker.Value = new System.DateTime(2023, 9, 11, 16, 38, 48, 810);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(516, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 45);
            this.label4.TabIndex = 45;
            this.label4.Text = "Reference";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Voir
            // 
            this.Voir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.Voir.Enabled = false;
            this.Voir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voir.Font = new System.Drawing.Font("Calibri", 8.875F, System.Drawing.FontStyle.Bold);
            this.Voir.ForeColor = System.Drawing.Color.White;
            this.Voir.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Voir.IconColor = System.Drawing.Color.White;
            this.Voir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Voir.IconSize = 40;
            this.Voir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Voir.Location = new System.Drawing.Point(964, 360);
            this.Voir.Name = "Voir";
            this.Voir.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.Voir.Size = new System.Drawing.Size(264, 74);
            this.Voir.TabIndex = 48;
            this.Voir.Tag = "Triage";
            this.Voir.Text = "Voir les manuels";
            this.Voir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Voir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Voir.UseVisualStyleBackColor = false;
            this.Voir.Visible = false;
            this.Voir.Click += new System.EventHandler(this.Voir_Click);
            // 
            // Addfile
            // 
            this.Addfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.Addfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addfile.Font = new System.Drawing.Font("Calibri", 8.875F, System.Drawing.FontStyle.Bold);
            this.Addfile.ForeColor = System.Drawing.Color.White;
            this.Addfile.IconChar = FontAwesome.Sharp.IconChar.File;
            this.Addfile.IconColor = System.Drawing.Color.White;
            this.Addfile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Addfile.IconSize = 40;
            this.Addfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addfile.Location = new System.Drawing.Point(12, 450);
            this.Addfile.Name = "Addfile";
            this.Addfile.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.Addfile.Size = new System.Drawing.Size(325, 74);
            this.Addfile.TabIndex = 47;
            this.Addfile.Tag = "Triage";
            this.Addfile.Text = "Ajouter un manuel";
            this.Addfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addfile.UseVisualStyleBackColor = false;
            this.Addfile.Click += new System.EventHandler(this.Addfile_Click);
            // 
            // Ref
            // 
            this.Ref.Animated = true;
            this.Ref.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ref.DefaultText = "";
            this.Ref.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Ref.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Ref.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ref.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ref.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ref.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Ref.ForeColor = System.Drawing.Color.Black;
            this.Ref.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ref.Location = new System.Drawing.Point(524, 95);
            this.Ref.Margin = new System.Windows.Forms.Padding(5);
            this.Ref.Name = "Ref";
            this.Ref.Padding = new System.Windows.Forms.Padding(10);
            this.Ref.PasswordChar = '\0';
            this.Ref.PlaceholderText = "";
            this.Ref.SelectedText = "";
            this.Ref.Size = new System.Drawing.Size(317, 45);
            this.Ref.TabIndex = 44;
            // 
            // CompNum
            // 
            this.CompNum.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CompNum.Font = new System.Drawing.Font("Lucida Console", 15.125F, System.Drawing.FontStyle.Bold);
            this.CompNum.ForeColor = System.Drawing.Color.Black;
            this.CompNum.Location = new System.Drawing.Point(1894, 354);
            this.CompNum.Name = "CompNum";
            this.CompNum.Size = new System.Drawing.Size(80, 80);
            this.CompNum.TabIndex = 41;
            this.CompNum.Text = "23";
            this.CompNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompNum.Click += new System.EventHandler(this.CompNum_Click);
            // 
            // MacName
            // 
            this.MacName.Animated = true;
            this.MacName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MacName.DefaultText = "";
            this.MacName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MacName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MacName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MacName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MacName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MacName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.MacName.ForeColor = System.Drawing.Color.Black;
            this.MacName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MacName.Location = new System.Drawing.Point(17, 94);
            this.MacName.Margin = new System.Windows.Forms.Padding(5);
            this.MacName.Name = "MacName";
            this.MacName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.MacName.PasswordChar = '\0';
            this.MacName.PlaceholderText = "";
            this.MacName.SelectedText = "";
            this.MacName.Size = new System.Drawing.Size(346, 46);
            this.MacName.TabIndex = 40;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.Ok.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Ok.IconColor = System.Drawing.Color.Black;
            this.Ok.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.Location = new System.Drawing.Point(1759, 63);
            this.Ok.Name = "Ok";
            this.Ok.Padding = new System.Windows.Forms.Padding(10);
            this.Ok.Size = new System.Drawing.Size(215, 76);
            this.Ok.TabIndex = 38;
            this.Ok.Text = "Confimer";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Red;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(1455, 64);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton5.Size = new System.Drawing.Size(216, 76);
            this.iconButton5.TabIndex = 39;
            this.iconButton5.Text = "Annuler";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // TypeCom
            // 
            this.TypeCom.BackColor = System.Drawing.Color.Transparent;
            this.TypeCom.BorderColor = System.Drawing.Color.Black;
            this.TypeCom.BorderRadius = 2;
            this.TypeCom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TypeCom.BorderThickness = 4;
            this.TypeCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeCom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeCom.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.TypeCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypeCom.ItemHeight = 30;
            this.TypeCom.Items.AddRange(new object[] {
            "Tecno-ferrari",
            "Banc",
            "Triage",
            "New-check",
            "CPK",
            "Accoppiatore",
            "Extra-pack",
            "Maxi-pack"});
            this.TypeCom.Location = new System.Drawing.Point(964, 103);
            this.TypeCom.Name = "TypeCom";
            this.TypeCom.Size = new System.Drawing.Size(317, 36);
            this.TypeCom.TabIndex = 35;
            this.TypeCom.SelectedIndexChanged += new System.EventHandler(this.TypeCom_SelectedIndexChanged);
            this.TypeCom.Click += new System.EventHandler(this.TypeCom_Click);
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
            this.AjouCour.Location = new System.Drawing.Point(12, 1213);
            this.AjouCour.Name = "AjouCour";
            this.AjouCour.Size = new System.Drawing.Size(346, 84);
            this.AjouCour.TabIndex = 34;
            this.AjouCour.Tag = "Ajouter une machine";
            this.AjouCour.Text = "Ajouter une courroie";
            this.AjouCour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouCour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AjouCour.UseVisualStyleBackColor = false;
            this.AjouCour.Click += new System.EventHandler(this.AjouCour_Click);
            // 
            // ajouver
            // 
            this.ajouver.BackColor = System.Drawing.Color.Teal;
            this.ajouver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouver.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ajouver.IconChar = FontAwesome.Sharp.IconChar.V;
            this.ajouver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ajouver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ajouver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouver.Location = new System.Drawing.Point(12, 1069);
            this.ajouver.Name = "ajouver";
            this.ajouver.Size = new System.Drawing.Size(346, 84);
            this.ajouver.TabIndex = 34;
            this.ajouver.Tag = "Ajouter une machine";
            this.ajouver.Text = "Ajouter un vérin";
            this.ajouver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajouver.UseVisualStyleBackColor = false;
            this.ajouver.Click += new System.EventHandler(this.ajouver_Click);
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
            this.Ajoured.Location = new System.Drawing.Point(12, 916);
            this.Ajoured.Name = "Ajoured";
            this.Ajoured.Size = new System.Drawing.Size(346, 84);
            this.Ajoured.TabIndex = 34;
            this.Ajoured.Tag = "Ajouter une machine";
            this.Ajoured.Text = "Ajouter un Reducteur";
            this.Ajoured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoured.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoured.UseVisualStyleBackColor = false;
            this.Ajoured.Click += new System.EventHandler(this.Ajoured_Click);
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
            this.Ajoumot.Location = new System.Drawing.Point(12, 754);
            this.Ajoumot.Name = "Ajoumot";
            this.Ajoumot.Size = new System.Drawing.Size(346, 84);
            this.Ajoumot.TabIndex = 34;
            this.Ajoumot.Tag = "Ajouter un moteur";
            this.Ajoumot.Text = "Ajouter un moteur";
            this.Ajoumot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoumot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoumot.UseVisualStyleBackColor = false;
            this.Ajoumot.Click += new System.EventHandler(this.Ajoumot_Click);
            // 
            // Ajout_button
            // 
            this.Ajout_button.BackColor = System.Drawing.Color.Teal;
            this.Ajout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajout_button.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_button.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.Ajout_button.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_button.Location = new System.Drawing.Point(12, 602);
            this.Ajout_button.Name = "Ajout_button";
            this.Ajout_button.Size = new System.Drawing.Size(346, 84);
            this.Ajout_button.TabIndex = 34;
            this.Ajout_button.Tag = "Ajouter une machine";
            this.Ajout_button.Text = "Ajouter un capteur";
            this.Ajout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_button.UseVisualStyleBackColor = false;
            this.Ajout_button.Click += new System.EventHandler(this.Ajout_button_Click);
            // 
            // AjouterMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(2013, 1332);
            this.Controls.Add(this.Voir);
            this.Controls.Add(this.Addfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.date);
            this.Controls.Add(this.CompNum);
            this.Controls.Add(this.MacName);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCom);
            this.Controls.Add(this.AjouCour);
            this.Controls.Add(this.ajouver);
            this.Controls.Add(this.Ajoured);
            this.Controls.Add(this.Ajoumot);
            this.Controls.Add(this.Ajout_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caps);
            this.Controls.Add(this.Composants);
            this.Controls.Add(this.Compos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterMachine_FormClosing);
            this.Load += new System.EventHandler(this.AjouterMachine_Load);
            this.Shown += new System.EventHandler(this.AjouterMachine_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Composants;
        private MetroFramework.Controls.MetroGrid Compos;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundedTextBox MacName;
        private RoundedButton Ajout_button;
        private RoundedButton Ajoumot;
        private RoundedButton Ajoured;
        private RoundedButton ajouver;
        private RoundedButton AjouCour;
        private RoundedButton Ok;
        private RoundedButton iconButton5;
        private FlatCombo TypeCom;
        private RoundedLabel CompNum;
        private System.Windows.Forms.Label date;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private System.Windows.Forms.Label label4;
        private RoundedTextBox Ref;
        private RoundedButton Addfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private RoundedButton Voir;
    }
}