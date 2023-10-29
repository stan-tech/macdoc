namespace macdoc
{
    partial class Arrivage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrivage));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.unit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.Compos = new macdoc.RoundedGrid();
            this.Ajouter = new macdoc.RoundedButton();
            this.Ok = new macdoc.RoundedButton();
            this.Retirer = new macdoc.RoundedButton();
            this.CapRef = new macdoc.RoundedTextBox();
            this.CapName = new macdoc.RoundedTextBox();
            this.price_unit = new macdoc.RoundedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Qt = new macdoc.RoundedTextBox();
            this.roundedButton4 = new macdoc.RoundedButton();
            this.roundedButton5 = new macdoc.RoundedButton();
            this.roundedButton3 = new macdoc.RoundedButton();
            this.cap_vie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dureeDeVie = new macdoc.RoundedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(581, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 39);
            this.label3.TabIndex = 60;
            this.label3.Text = "DZD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 50);
            this.label2.TabIndex = 61;
            this.label2.Text = "Prix unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 50);
            this.label4.TabIndex = 65;
            this.label4.Text = "Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 50);
            this.label5.TabIndex = 66;
            this.label5.Text = "Nom";
            // 
            // caps
            // 
            this.caps.AllowDrop = true;
            this.caps.BackColor = System.Drawing.Color.Transparent;
            this.caps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.caps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caps.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.FocusedState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caps.ForeColor = System.Drawing.Color.Black;
            this.caps.HoverState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ItemHeight = 30;
            this.caps.Items.AddRange(new object[] {
            "Capteur",
            "Moteur",
            "Reducteur",
            "Huile",
            "Courroie"});
            this.caps.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.Location = new System.Drawing.Point(266, 139);
            this.caps.MaxDropDownItems = 28;
            this.caps.Name = "caps";
            this.caps.ShadowDecoration.BorderRadius = 8;
            this.caps.Size = new System.Drawing.Size(319, 36);
            this.caps.TabIndex = 71;
            this.caps.SelectedIndexChanged += new System.EventHandler(this.caps_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 50);
            this.label6.TabIndex = 66;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 870);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 50);
            this.label7.TabIndex = 61;
            this.label7.Text = "Prix total";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Green;
            this.price.Location = new System.Drawing.Point(342, 870);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(110, 59);
            this.price.TabIndex = 61;
            this.price.Text = "0.00";
            // 
            // unit
            // 
            this.unit.AllowDrop = true;
            this.unit.BackColor = System.Drawing.Color.Transparent;
            this.unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unit.FocusedState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.unit.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.unit.ForeColor = System.Drawing.Color.Black;
            this.unit.HoverState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.unit.ItemHeight = 30;
            this.unit.Items.AddRange(new object[] {
            "Litre",
            "Unité"});
            this.unit.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.unit.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.unit.Location = new System.Drawing.Point(301, 467);
            this.unit.MaxDropDownItems = 28;
            this.unit.Name = "unit";
            this.unit.ShadowDecoration.BorderRadius = 8;
            this.unit.Size = new System.Drawing.Size(284, 36);
            this.unit.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 65;
            this.label1.Text = "Unité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(569, 886);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 39);
            this.label8.TabIndex = 60;
            this.label8.Text = "DZD";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Red;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.roundedButton1.IconColor = System.Drawing.Color.White;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton1.IconSize = 28;
            this.roundedButton1.Location = new System.Drawing.Point(1733, 30);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(15);
            this.roundedButton1.Size = new System.Drawing.Size(55, 55);
            this.roundedButton1.TabIndex = 73;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.Compos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Compos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Compos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Compos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Compos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Compos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Compos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Compos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Compos.EnableHeadersVisualStyles = false;
            this.Compos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Compos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.Location = new System.Drawing.Point(656, 130);
            this.Compos.Name = "Compos";
            this.Compos.ReadOnly = true;
            this.Compos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Compos.RowHeadersWidth = 82;
            this.Compos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(16, 29, 16, 29);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Compos.RowTemplate.DividerHeight = 2;
            this.Compos.RowTemplate.Height = 203;
            this.Compos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Compos.Size = new System.Drawing.Size(1132, 1003);
            this.Compos.Style = MetroFramework.MetroColorStyle.Teal;
            this.Compos.TabIndex = 72;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ajouter.IconColor = System.Drawing.Color.White;
            this.Ajouter.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Ajouter.Location = new System.Drawing.Point(44, 1062);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(597, 71);
            this.Ajouter.TabIndex = 69;
            this.Ajouter.Text = "Finaliser";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Ok.IconColor = System.Drawing.Color.White;
            this.Ok.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.Location = new System.Drawing.Point(427, 968);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(214, 71);
            this.Ok.TabIndex = 69;
            this.Ok.Text = "Confimer";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Retirer
            // 
            this.Retirer.BackColor = System.Drawing.Color.Red;
            this.Retirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retirer.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.Retirer.ForeColor = System.Drawing.Color.White;
            this.Retirer.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Retirer.IconColor = System.Drawing.Color.White;
            this.Retirer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Retirer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retirer.Location = new System.Drawing.Point(44, 968);
            this.Retirer.Name = "Retirer";
            this.Retirer.Size = new System.Drawing.Size(214, 71);
            this.Retirer.TabIndex = 70;
            this.Retirer.Text = "Retirer";
            this.Retirer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retirer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Retirer.UseVisualStyleBackColor = false;
            this.Retirer.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // CapRef
            // 
            this.CapRef.Animated = true;
            this.CapRef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CapRef.DefaultText = "";
            this.CapRef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CapRef.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CapRef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CapRef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CapRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CapRef.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CapRef.ForeColor = System.Drawing.Color.Black;
            this.CapRef.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CapRef.Location = new System.Drawing.Point(232, 348);
            this.CapRef.Margin = new System.Windows.Forms.Padding(5);
            this.CapRef.Name = "CapRef";
            this.CapRef.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapRef.PasswordChar = '\0';
            this.CapRef.PlaceholderText = "";
            this.CapRef.SelectedText = "";
            this.CapRef.Size = new System.Drawing.Size(356, 60);
            this.CapRef.TabIndex = 67;
            // 
            // CapName
            // 
            this.CapName.Animated = true;
            this.CapName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CapName.DefaultText = "";
            this.CapName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CapName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CapName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CapName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CapName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CapName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CapName.ForeColor = System.Drawing.Color.Black;
            this.CapName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CapName.Location = new System.Drawing.Point(232, 233);
            this.CapName.Margin = new System.Windows.Forms.Padding(5);
            this.CapName.Name = "CapName";
            this.CapName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapName.PasswordChar = '\0';
            this.CapName.PlaceholderText = "";
            this.CapName.SelectedText = "";
            this.CapName.Size = new System.Drawing.Size(356, 60);
            this.CapName.TabIndex = 68;
            // 
            // price_unit
            // 
            this.price_unit.Animated = true;
            this.price_unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_unit.DefaultText = "";
            this.price_unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_unit.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_unit.ForeColor = System.Drawing.Color.Black;
            this.price_unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_unit.Location = new System.Drawing.Point(262, 664);
            this.price_unit.Margin = new System.Windows.Forms.Padding(5);
            this.price_unit.Name = "price_unit";
            this.price_unit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.price_unit.PasswordChar = '\0';
            this.price_unit.PlaceholderText = "";
            this.price_unit.SelectedText = "";
            this.price_unit.Size = new System.Drawing.Size(316, 50);
            this.price_unit.TabIndex = 58;
            this.price_unit.TextOffset = new System.Drawing.Point(10, -2);
            this.price_unit.TextChanged += new System.EventHandler(this.price_unit_TextChanged);
            this.price_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_unit_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 50);
            this.label9.TabIndex = 77;
            this.label9.Text = "Quantité";
            // 
            // Qt
            // 
            this.Qt.Animated = true;
            this.Qt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qt.DefaultText = "1";
            this.Qt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Qt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Qt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qt.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qt.ForeColor = System.Drawing.Color.Black;
            this.Qt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qt.Location = new System.Drawing.Point(283, 553);
            this.Qt.Margin = new System.Windows.Forms.Padding(5);
            this.Qt.Name = "Qt";
            this.Qt.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Qt.PasswordChar = '\0';
            this.Qt.PlaceholderText = "";
            this.Qt.SelectedText = "";
            this.Qt.Size = new System.Drawing.Size(303, 50);
            this.Qt.TabIndex = 76;
            this.Qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qt.TextOffset = new System.Drawing.Point(10, -2);
            this.Qt.TextChanged += new System.EventHandler(this.Qt_TextChanged);
            this.Qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qt_KeyPress);
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton4.BackgroundImage")));
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.roundedButton4.IconColor = System.Drawing.Color.Black;
            this.roundedButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton4.IconSize = 38;
            this.roundedButton4.Location = new System.Drawing.Point(594, 558);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.roundedButton4.Size = new System.Drawing.Size(47, 47);
            this.roundedButton4.TabIndex = 78;
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton5.BackgroundImage")));
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton5.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.roundedButton5.IconColor = System.Drawing.Color.Black;
            this.roundedButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton5.IconSize = 38;
            this.roundedButton5.Location = new System.Drawing.Point(232, 558);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.roundedButton5.Size = new System.Drawing.Size(47, 47);
            this.roundedButton5.TabIndex = 78;
            this.roundedButton5.UseVisualStyleBackColor = false;
            this.roundedButton5.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.roundedButton3.ForeColor = System.Drawing.Color.Black;
            this.roundedButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.roundedButton3.IconColor = System.Drawing.Color.White;
            this.roundedButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton3.IconSize = 30;
            this.roundedButton3.Location = new System.Drawing.Point(51, 30);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(10);
            this.roundedButton3.Size = new System.Drawing.Size(55, 55);
            this.roundedButton3.TabIndex = 79;
            this.roundedButton3.Tag = "Triage";
            this.roundedButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // cap_vie
            // 
            this.cap_vie.BackColor = System.Drawing.Color.Transparent;
            this.cap_vie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cap_vie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cap_vie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cap_vie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cap_vie.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap_vie.ForeColor = System.Drawing.Color.Black;
            this.cap_vie.HoverState.BorderColor = System.Drawing.Color.Black;
            this.cap_vie.HoverState.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap_vie.ItemHeight = 48;
            this.cap_vie.Items.AddRange(new object[] {
            "Jours",
            "Semaines",
            "Mois",
            "Ans"});
            this.cap_vie.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cap_vie.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap_vie.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cap_vie.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cap_vie.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Gray;
            this.cap_vie.Location = new System.Drawing.Point(410, 771);
            this.cap_vie.Name = "cap_vie";
            this.cap_vie.Size = new System.Drawing.Size(231, 54);
            this.cap_vie.TabIndex = 85;
            this.cap_vie.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dureeDeVie
            // 
            this.dureeDeVie.Animated = true;
            this.dureeDeVie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dureeDeVie.DefaultText = "";
            this.dureeDeVie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dureeDeVie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dureeDeVie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dureeDeVie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dureeDeVie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dureeDeVie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dureeDeVie.ForeColor = System.Drawing.Color.Black;
            this.dureeDeVie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dureeDeVie.Location = new System.Drawing.Point(260, 769);
            this.dureeDeVie.Margin = new System.Windows.Forms.Padding(5);
            this.dureeDeVie.Name = "dureeDeVie";
            this.dureeDeVie.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dureeDeVie.PasswordChar = '\0';
            this.dureeDeVie.PlaceholderText = "";
            this.dureeDeVie.SelectedText = "";
            this.dureeDeVie.Size = new System.Drawing.Size(165, 57);
            this.dureeDeVie.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 774);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 50);
            this.label10.TabIndex = 83;
            this.label10.Text = "Durée de vie";
            // 
            // Arrivage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1813, 1156);
            this.Controls.Add(this.dureeDeVie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton5);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Qt);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.Compos);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.caps);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Retirer);
            this.Controls.Add(this.CapRef);
            this.Controls.Add(this.CapName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_unit);
            this.Controls.Add(this.cap_vie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arrivage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrivage";
            this.Load += new System.EventHandler(this.Arrivage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public RoundedTextBox price_unit;
        private RoundedTextBox CapRef;
        private RoundedTextBox CapName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RoundedButton Ok;
        private RoundedButton Retirer;
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label price;
        private RoundedButton Ajouter;
        public RoundedGrid Compos;
        private Guna.UI2.WinForms.Guna2ComboBox unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label9;
        public RoundedTextBox Qt;
        private RoundedButton roundedButton4;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton3;
        private Guna.UI2.WinForms.Guna2ComboBox cap_vie;
        private RoundedTextBox dureeDeVie;
        private System.Windows.Forms.Label label10;
    }
}