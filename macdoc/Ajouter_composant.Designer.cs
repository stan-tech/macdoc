namespace macdoc
{
    partial class Ajouter_composant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_composant));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Date_insertion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cap_vie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dureeDeVie = new macdoc.RoundedTextBox();
            this.CapRef = new macdoc.RoundedTextBox();
            this.CapName = new macdoc.RoundedTextBox();
            this.Ok = new macdoc.RoundedButton();
            this.Annuler = new macdoc.RoundedButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date d\'insertion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 45);
            this.label3.TabIndex = 29;
            this.label3.Text = "Durée de vie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 30;
            this.label2.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nom";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(394, 579);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 49);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Aujourd\'hui";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Date_insertion
            // 
            this.Date_insertion.Checked = true;
            this.Date_insertion.CustomFormat = "dd/MM/yyyy";
            this.Date_insertion.FillColor = System.Drawing.Color.DarkTurquoise;
            this.Date_insertion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date_insertion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_insertion.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Date_insertion.HoverState.FillColor = System.Drawing.Color.GreenYellow;
            this.Date_insertion.Location = new System.Drawing.Point(328, 491);
            this.Date_insertion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_insertion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_insertion.Name = "Date_insertion";
            this.Date_insertion.Size = new System.Drawing.Size(300, 36);
            this.Date_insertion.TabIndex = 22;
            this.Date_insertion.Value = new System.DateTime(2023, 9, 11, 16, 38, 48, 810);
            // 
            // cap_vie
            // 
            this.cap_vie.BackColor = System.Drawing.Color.Transparent;
            this.cap_vie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cap_vie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cap_vie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cap_vie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cap_vie.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.cap_vie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cap_vie.ItemHeight = 30;
            this.cap_vie.Items.AddRange(new object[] {
            "Jours",
            "Semaines",
            "Mois",
            "Ans"});
            this.cap_vie.Location = new System.Drawing.Point(437, 367);
            this.cap_vie.Name = "cap_vie";
            this.cap_vie.Size = new System.Drawing.Size(218, 36);
            this.cap_vie.TabIndex = 44;
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
            this.dureeDeVie.Location = new System.Drawing.Point(266, 357);
            this.dureeDeVie.Margin = new System.Windows.Forms.Padding(5);
            this.dureeDeVie.Name = "dureeDeVie";
            this.dureeDeVie.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dureeDeVie.PasswordChar = '\0';
            this.dureeDeVie.PlaceholderText = "";
            this.dureeDeVie.SelectedText = "";
            this.dureeDeVie.Size = new System.Drawing.Size(162, 46);
            this.dureeDeVie.TabIndex = 43;
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
            this.CapRef.Location = new System.Drawing.Point(266, 234);
            this.CapRef.Margin = new System.Windows.Forms.Padding(5);
            this.CapRef.Name = "CapRef";
            this.CapRef.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapRef.PasswordChar = '\0';
            this.CapRef.PlaceholderText = "";
            this.CapRef.SelectedText = "";
            this.CapRef.Size = new System.Drawing.Size(389, 46);
            this.CapRef.TabIndex = 42;
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
            this.CapName.Location = new System.Drawing.Point(266, 112);
            this.CapName.Margin = new System.Windows.Forms.Padding(5);
            this.CapName.Name = "CapName";
            this.CapName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapName.PasswordChar = '\0';
            this.CapName.PlaceholderText = "";
            this.CapName.SelectedText = "";
            this.CapName.Size = new System.Drawing.Size(389, 46);
            this.CapName.TabIndex = 41;
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
            this.Ok.Location = new System.Drawing.Point(437, 725);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(191, 76);
            this.Ok.TabIndex = 23;
            this.Ok.Text = "Confimer";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
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
            this.Annuler.Location = new System.Drawing.Point(75, 725);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(182, 76);
            this.Annuler.TabIndex = 24;
            this.Annuler.Text = "Annuler";
            this.Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Ajouter_composant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(680, 844);
            this.Controls.Add(this.cap_vie);
            this.Controls.Add(this.dureeDeVie);
            this.Controls.Add(this.CapRef);
            this.Controls.Add(this.CapName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Date_insertion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajouter_composant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un composant";
            this.Load += new System.EventHandler(this.Ajouter_composant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date_insertion;
        private RoundedTextBox CapName;
        private RoundedTextBox CapRef;
        private RoundedTextBox dureeDeVie;
        private RoundedButton Ok;
        private RoundedButton Annuler;
        private Guna.UI2.WinForms.Guna2ComboBox cap_vie;
    }
}