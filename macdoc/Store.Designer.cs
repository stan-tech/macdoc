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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Compos = new MetroFramework.Controls.MetroGrid();
            this.Composants = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton3 = new macdoc.RoundedButton();
            this.roundedButton2 = new macdoc.RoundedButton();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.Ajouter = new macdoc.RoundedButton();
            this.roundedTextBox1 = new macdoc.RoundedTextBox();
            this.Search = new macdoc.RoundedTextBox();
            this.AjouCour = new macdoc.RoundedButton();
            this.ajouver = new macdoc.RoundedButton();
            this.Ajoured = new macdoc.RoundedButton();
            this.Ajoumot = new macdoc.RoundedButton();
            this.Ajout_button = new macdoc.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.panel1.SuspendLayout();
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
            "Capteurs",
            "Moteurs",
            "Reducteurs",
            "Vérins",
            "Courroies"});
            this.caps.Location = new System.Drawing.Point(1401, 99);
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size(317, 36);
            this.caps.TabIndex = 50;
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
            this.Compos.Location = new System.Drawing.Point(424, 198);
            this.Compos.Name = "Compos";
            this.Compos.ReadOnly = true;
            this.Compos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.Compos.RowTemplate.Height = 63;
            this.Compos.RowTemplate.ReadOnly = true;
            this.Compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Compos.Size = new System.Drawing.Size(1294, 682);
            this.Compos.Style = MetroFramework.MetroColorStyle.Silver;
            this.Compos.TabIndex = 49;
            // 
            // Composants
            // 
            this.Composants.AutoSize = true;
            this.Composants.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Composants.ForeColor = System.Drawing.Color.White;
            this.Composants.Location = new System.Drawing.Point(1217, 90);
            this.Composants.Name = "Composants";
            this.Composants.Size = new System.Drawing.Size(149, 45);
            this.Composants.TabIndex = 56;
            this.Composants.Text = "Trier par";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedButton3);
            this.panel1.Controls.Add(this.roundedButton2);
            this.panel1.Controls.Add(this.roundedButton1);
            this.panel1.Controls.Add(this.Ajouter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roundedTextBox1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 157);
            this.panel1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(584, 89);
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
            this.label2.Location = new System.Drawing.Point(435, 25);
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
            this.label1.Location = new System.Drawing.Point(125, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quantité";
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.roundedButton3.IconColor = System.Drawing.Color.Black;
            this.roundedButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton3.IconSize = 38;
            this.roundedButton3.Location = new System.Drawing.Point(22, 76);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(15);
            this.roundedButton3.Size = new System.Drawing.Size(60, 58);
            this.roundedButton3.TabIndex = 57;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.roundedButton2.IconColor = System.Drawing.Color.Black;
            this.roundedButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton2.IconSize = 38;
            this.roundedButton2.Location = new System.Drawing.Point(325, 76);
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
            this.roundedButton1.Location = new System.Drawing.Point(909, 67);
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
            this.Ajouter.Location = new System.Drawing.Point(693, 67);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Ajouter.Size = new System.Drawing.Size(198, 58);
            this.Ajouter.TabIndex = 56;
            this.Ajouter.Tag = "Ajouter une machine";
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.Animated = true;
            this.roundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roundedTextBox1.DefaultText = "";
            this.roundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roundedTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.roundedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roundedTextBox1.Location = new System.Drawing.Point(412, 80);
            this.roundedTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.roundedTextBox1.PasswordChar = '\0';
            this.roundedTextBox1.PlaceholderText = "";
            this.roundedTextBox1.SelectedText = "";
            this.roundedTextBox1.Size = new System.Drawing.Size(173, 50);
            this.roundedTextBox1.TabIndex = 42;
            // 
            // Search
            // 
            this.Search.Animated = true;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.DefaultText = "";
            this.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.Location = new System.Drawing.Point(90, 80);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderText = "";
            this.Search.SelectedText = "";
            this.Search.Size = new System.Drawing.Size(227, 50);
            this.Search.TabIndex = 42;
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
            this.AjouCour.Location = new System.Drawing.Point(19, 788);
            this.AjouCour.Name = "AjouCour";
            this.AjouCour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AjouCour.Size = new System.Drawing.Size(369, 92);
            this.AjouCour.TabIndex = 51;
            this.AjouCour.Tag = "Ajouter une machine";
            this.AjouCour.Text = "Acheter des courroies";
            this.AjouCour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouCour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AjouCour.UseVisualStyleBackColor = false;
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
            this.ajouver.Location = new System.Drawing.Point(19, 638);
            this.ajouver.Name = "ajouver";
            this.ajouver.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ajouver.Size = new System.Drawing.Size(369, 92);
            this.ajouver.TabIndex = 52;
            this.ajouver.Tag = "Ajouter une machine";
            this.ajouver.Text = "Acheter d\'huile ";
            this.ajouver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajouver.UseVisualStyleBackColor = false;
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
            this.Ajoured.Location = new System.Drawing.Point(19, 491);
            this.Ajoured.Name = "Ajoured";
            this.Ajoured.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajoured.Size = new System.Drawing.Size(369, 92);
            this.Ajoured.TabIndex = 53;
            this.Ajoured.Tag = "Ajouter une machine";
            this.Ajoured.Text = "Acheter des reducteurs";
            this.Ajoured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoured.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoured.UseVisualStyleBackColor = false;
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
            this.Ajoumot.Location = new System.Drawing.Point(19, 343);
            this.Ajoumot.Name = "Ajoumot";
            this.Ajoumot.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajoumot.Size = new System.Drawing.Size(369, 92);
            this.Ajoumot.TabIndex = 54;
            this.Ajoumot.Tag = "Ajouter un moteur";
            this.Ajoumot.Text = "Acheter des moteurs";
            this.Ajoumot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajoumot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajoumot.UseVisualStyleBackColor = false;
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
            this.Ajout_button.Location = new System.Drawing.Point(19, 198);
            this.Ajout_button.Name = "Ajout_button";
            this.Ajout_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Ajout_button.Size = new System.Drawing.Size(369, 92);
            this.Ajout_button.TabIndex = 55;
            this.Ajout_button.Tag = "Ajouter une machine";
            this.Ajout_button.Text = "Acheter des capteurs";
            this.Ajout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_button.UseVisualStyleBackColor = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1755, 909);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Composants);
            this.Controls.Add(this.AjouCour);
            this.Controls.Add(this.ajouver);
            this.Controls.Add(this.Ajoured);
            this.Controls.Add(this.Ajoumot);
            this.Controls.Add(this.Ajout_button);
            this.Controls.Add(this.caps);
            this.Controls.Add(this.Compos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton AjouCour;
        private RoundedButton ajouver;
        private RoundedButton Ajoured;
        private RoundedButton Ajoumot;
        private RoundedButton Ajout_button;
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        public MetroFramework.Controls.MetroGrid Compos;
        private System.Windows.Forms.Label Composants;
        private System.Windows.Forms.Panel panel1;
        public RoundedTextBox Search;
        public RoundedTextBox roundedTextBox1;
        private RoundedButton Ajouter;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton2;
    }
}