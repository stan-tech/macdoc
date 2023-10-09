namespace macdoc
{
    partial class ModifierMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierMachine));
            this.MacName = new macdoc.RoundedTextBox();
            this.Composants = new System.Windows.Forms.Label();
            this.Compos = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Ajout_button = new macdoc.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCom = new macdoc.FlatCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.Ajout_motor = new macdoc.RoundedButton();
            this.Ajout_reduc = new macdoc.RoundedButton();
            this.ajout_verin = new macdoc.RoundedButton();
            this.ajout_courr = new macdoc.RoundedButton();
            this.Annuler = new macdoc.RoundedButton();
            this.Ok = new macdoc.RoundedButton();
            this.CompNum = new macdoc.RoundedLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.Ref = new macdoc.RoundedLabel();
            this.Addfile = new macdoc.RoundedButton();
            this.Voir = new macdoc.RoundedButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.SuspendLayout();
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
            this.MacName.Location = new System.Drawing.Point(33, 104);
            this.MacName.Margin = new System.Windows.Forms.Padding(5);
            this.MacName.Name = "MacName";
            this.MacName.Padding = new System.Windows.Forms.Padding(10);
            this.MacName.PasswordChar = '\0';
            this.MacName.PlaceholderText = "";
            this.MacName.SelectedText = "";
            this.MacName.Size = new System.Drawing.Size(284, 45);
            this.MacName.TabIndex = 14;
            // 
            // Composants
            // 
            this.Composants.AutoSize = true;
            this.Composants.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Composants.ForeColor = System.Drawing.Color.White;
            this.Composants.Location = new System.Drawing.Point(414, 328);
            this.Composants.Name = "Composants";
            this.Composants.Size = new System.Drawing.Size(158, 45);
            this.Composants.TabIndex = 30;
            this.Composants.Text = "Capteurs";
            this.Composants.Click += new System.EventHandler(this.Composants_Click);
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
            this.Compos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.Compos.Location = new System.Drawing.Point(412, 388);
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
            this.Compos.Size = new System.Drawing.Size(1435, 777);
            this.Compos.Style = MetroFramework.MetroColorStyle.Silver;
            this.Compos.TabIndex = 29;
            this.Compos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Compos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1383, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "Composants";
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
            this.caps.Location = new System.Drawing.Point(1391, 337);
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size(317, 36);
            this.caps.TabIndex = 31;
            this.caps.SelectedIndexChanged += new System.EventHandler(this.caps_SelectedIndexChanged);
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
            this.Ajout_button.Location = new System.Drawing.Point(33, 527);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(782, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 45);
            this.label2.TabIndex = 36;
            this.label2.Text = "Type";
            // 
            // TypeCom
            // 
            this.TypeCom.BackColor = System.Drawing.Color.Transparent;
            this.TypeCom.BorderColor = System.Drawing.Color.Blue;
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
            "Maxi"});
            this.TypeCom.Location = new System.Drawing.Point(790, 113);
            this.TypeCom.Name = "TypeCom";
            this.TypeCom.Size = new System.Drawing.Size(286, 36);
            this.TypeCom.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 45);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nom";
            // 
            // Ajout_motor
            // 
            this.Ajout_motor.BackColor = System.Drawing.Color.Teal;
            this.Ajout_motor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajout_motor.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_motor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_motor.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.Ajout_motor.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_motor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajout_motor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_motor.Location = new System.Drawing.Point(33, 665);
            this.Ajout_motor.Name = "Ajout_motor";
            this.Ajout_motor.Size = new System.Drawing.Size(346, 84);
            this.Ajout_motor.TabIndex = 34;
            this.Ajout_motor.Tag = "Ajouter un moteur";
            this.Ajout_motor.Text = "Ajouter un moteur";
            this.Ajout_motor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_motor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_motor.UseVisualStyleBackColor = false;
            this.Ajout_motor.Click += new System.EventHandler(this.Ajout_motor_Click);
            // 
            // Ajout_reduc
            // 
            this.Ajout_reduc.BackColor = System.Drawing.Color.Teal;
            this.Ajout_reduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajout_reduc.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_reduc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_reduc.IconChar = FontAwesome.Sharp.IconChar.Timeline;
            this.Ajout_reduc.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_reduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajout_reduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_reduc.Location = new System.Drawing.Point(33, 808);
            this.Ajout_reduc.Name = "Ajout_reduc";
            this.Ajout_reduc.Size = new System.Drawing.Size(346, 84);
            this.Ajout_reduc.TabIndex = 34;
            this.Ajout_reduc.Tag = "Ajouter une machine";
            this.Ajout_reduc.Text = "Ajouter un Reducteur";
            this.Ajout_reduc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_reduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_reduc.UseVisualStyleBackColor = false;
            this.Ajout_reduc.Click += new System.EventHandler(this.Ajout_reduc_Click);
            // 
            // ajout_verin
            // 
            this.ajout_verin.BackColor = System.Drawing.Color.Teal;
            this.ajout_verin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajout_verin.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_verin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ajout_verin.IconChar = FontAwesome.Sharp.IconChar.V;
            this.ajout_verin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ajout_verin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ajout_verin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajout_verin.Location = new System.Drawing.Point(33, 947);
            this.ajout_verin.Name = "ajout_verin";
            this.ajout_verin.Size = new System.Drawing.Size(346, 84);
            this.ajout_verin.TabIndex = 34;
            this.ajout_verin.Tag = "Ajouter une machine";
            this.ajout_verin.Text = "Ajouter un vérin";
            this.ajout_verin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajout_verin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajout_verin.UseVisualStyleBackColor = false;
            this.ajout_verin.Click += new System.EventHandler(this.ajout_verin_Click);
            // 
            // ajout_courr
            // 
            this.ajout_courr.BackColor = System.Drawing.Color.Teal;
            this.ajout_courr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajout_courr.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_courr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ajout_courr.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ajout_courr.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ajout_courr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ajout_courr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajout_courr.Location = new System.Drawing.Point(33, 1081);
            this.ajout_courr.Name = "ajout_courr";
            this.ajout_courr.Size = new System.Drawing.Size(346, 84);
            this.ajout_courr.TabIndex = 34;
            this.ajout_courr.Tag = "Ajouter une machine";
            this.ajout_courr.Text = "Ajouter une courroie";
            this.ajout_courr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajout_courr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ajout_courr.UseVisualStyleBackColor = false;
            this.ajout_courr.Click += new System.EventHandler(this.ajout_courr_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Red;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.Annuler.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Annuler.IconColor = System.Drawing.Color.Black;
            this.Annuler.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Annuler.Location = new System.Drawing.Point(1402, 73);
            this.Annuler.Name = "Annuler";
            this.Annuler.Padding = new System.Windows.Forms.Padding(10);
            this.Annuler.Size = new System.Drawing.Size(197, 76);
            this.Annuler.TabIndex = 39;
            this.Annuler.Text = "Annuler";
            this.Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Annuler.UseVisualStyleBackColor = false;
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
            this.Ok.Location = new System.Drawing.Point(1634, 73);
            this.Ok.Name = "Ok";
            this.Ok.Padding = new System.Windows.Forms.Padding(10);
            this.Ok.Size = new System.Drawing.Size(213, 76);
            this.Ok.TabIndex = 38;
            this.Ok.Text = "Confimer";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // CompNum
            // 
            this.CompNum.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CompNum.Font = new System.Drawing.Font("Lucida Console", 15.125F, System.Drawing.FontStyle.Bold);
            this.CompNum.ForeColor = System.Drawing.Color.Black;
            this.CompNum.Location = new System.Drawing.Point(1767, 293);
            this.CompNum.Name = "CompNum";
            this.CompNum.Size = new System.Drawing.Size(80, 80);
            this.CompNum.TabIndex = 40;
            this.CompNum.Text = "23";
            this.CompNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 45);
            this.label4.TabIndex = 37;
            this.label4.Text = "Reference";
            // 
            // Ref
            // 
            this.Ref.BackColor = System.Drawing.Color.White;
            this.Ref.Font = new System.Drawing.Font("Lucida Console", 11.125F, System.Drawing.FontStyle.Bold);
            this.Ref.ForeColor = System.Drawing.Color.Black;
            this.Ref.Location = new System.Drawing.Point(398, 104);
            this.Ref.Name = "Ref";
            this.Ref.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.Ref.Size = new System.Drawing.Size(298, 45);
            this.Ref.TabIndex = 40;
            this.Ref.Text = "23";
            this.Ref.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Addfile.Location = new System.Drawing.Point(33, 388);
            this.Addfile.Name = "Addfile";
            this.Addfile.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.Addfile.Size = new System.Drawing.Size(346, 74);
            this.Addfile.TabIndex = 48;
            this.Addfile.Tag = "Triage";
            this.Addfile.Text = "Ajouter un manuel";
            this.Addfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addfile.UseVisualStyleBackColor = false;
            this.Addfile.Click += new System.EventHandler(this.Addfile_Click);
            // 
            // Voir
            // 
            this.Voir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.Voir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voir.Font = new System.Drawing.Font("Calibri", 8.875F, System.Drawing.FontStyle.Bold);
            this.Voir.ForeColor = System.Drawing.Color.White;
            this.Voir.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Voir.IconColor = System.Drawing.Color.White;
            this.Voir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Voir.IconSize = 40;
            this.Voir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Voir.Location = new System.Drawing.Point(790, 299);
            this.Voir.Name = "Voir";
            this.Voir.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.Voir.Size = new System.Drawing.Size(264, 74);
            this.Voir.TabIndex = 49;
            this.Voir.Tag = "Triage";
            this.Voir.Text = "Voir les manuels";
            this.Voir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Voir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Voir.UseVisualStyleBackColor = false;
            this.Voir.Click += new System.EventHandler(this.Voir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModifierMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1886, 1191);
            this.Controls.Add(this.Voir);
            this.Controls.Add(this.Addfile);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.CompNum);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCom);
            this.Controls.Add(this.ajout_courr);
            this.Controls.Add(this.ajout_verin);
            this.Controls.Add(this.Ajout_reduc);
            this.Controls.Add(this.Ajout_motor);
            this.Controls.Add(this.Ajout_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caps);
            this.Controls.Add(this.Composants);
            this.Controls.Add(this.Compos);
            this.Controls.Add(this.MacName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une machine";
            this.Load += new System.EventHandler(this.ModifierMachine_Load);
            this.Shown += new System.EventHandler(this.ModifierMachine_Shown);
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
        private RoundedButton Ok;
        private RoundedButton Ajout_button;
        private RoundedButton Annuler;
        private RoundedButton Ajout_motor;
        private RoundedButton Ajout_reduc;
        private RoundedButton ajout_verin;
        private RoundedButton ajout_courr;
        private RoundedTextBox MacName;
        private RoundedLabel CompNum;
        private FlatCombo TypeCom;
        private System.Windows.Forms.Label label4;
        private RoundedLabel Ref;
        private RoundedButton Addfile;
        private RoundedButton Voir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}