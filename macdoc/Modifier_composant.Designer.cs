namespace macdoc
{
    partial class Modifier_composant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_composant));
            this.inst = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.modif = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notes = new macdoc.RoundedTextBox();
            this.CapRef = new macdoc.RoundedTextBox();
            this.CapName = new macdoc.RoundedTextBox();
            this.Ok = new macdoc.RoundedButton();
            this.Annuler = new macdoc.RoundedButton();
            this.SuspendLayout();
            // 
            // inst
            // 
            this.inst.Checked = true;
            this.inst.CustomFormat = "dd/MM/yyyy";
            this.inst.FillColor = System.Drawing.Color.DarkTurquoise;
            this.inst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inst.HoverState.FillColor = System.Drawing.Color.GreenYellow;
            this.inst.Location = new System.Drawing.Point(199, 338);
            this.inst.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inst.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inst.Name = "inst";
            this.inst.Size = new System.Drawing.Size(387, 36);
            this.inst.TabIndex = 6;
            this.inst.Value = new System.DateTime(2023, 9, 11, 17, 29, 32, 18);
            this.inst.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // modif
            // 
            this.modif.Checked = true;
            this.modif.CustomFormat = "dd/MM/yyyy";
            this.modif.FillColor = System.Drawing.Color.DarkTurquoise;
            this.modif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modif.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.modif.HoverState.FillColor = System.Drawing.Color.GreenYellow;
            this.modif.Location = new System.Drawing.Point(373, 440);
            this.modif.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.modif.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(213, 36);
            this.modif.TabIndex = 7;
            this.modif.Value = new System.DateTime(2023, 9, 11, 16, 38, 48, 810);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(351, 529);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 49);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Aujourd\'hui";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 45);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insertion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "derniére modification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 45);
            this.label5.TabIndex = 20;
            this.label5.Text = "Notes";
            // 
            // notes
            // 
            this.notes.Animated = true;
            this.notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.notes.DefaultText = "";
            this.notes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.notes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.notes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.notes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.notes.ForeColor = System.Drawing.Color.Black;
            this.notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notes.Location = new System.Drawing.Point(154, 615);
            this.notes.Margin = new System.Windows.Forms.Padding(5);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.notes.PasswordChar = '\0';
            this.notes.PlaceholderText = "";
            this.notes.SelectedText = "";
            this.notes.Size = new System.Drawing.Size(431, 240);
            this.notes.TabIndex = 42;
            // 
            // CapRef
            // 
            this.CapRef.AllowDrop = true;
            this.CapRef.Animated = true;
            this.CapRef.AutoRoundedCorners = true;
            this.CapRef.BorderRadius = 29;
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
            this.CapRef.Location = new System.Drawing.Point(224, 213);
            this.CapRef.Margin = new System.Windows.Forms.Padding(5);
            this.CapRef.Name = "CapRef";
            this.CapRef.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapRef.PasswordChar = '\0';
            this.CapRef.PlaceholderText = "";
            this.CapRef.SelectedText = "";
            this.CapRef.Size = new System.Drawing.Size(362, 60);
            this.CapRef.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
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
            this.CapName.Location = new System.Drawing.Point(224, 94);
            this.CapName.Margin = new System.Windows.Forms.Padding(5);
            this.CapName.Name = "CapName";
            this.CapName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CapName.PasswordChar = '\0';
            this.CapName.PlaceholderText = "";
            this.CapName.SelectedText = "";
            this.CapName.Size = new System.Drawing.Size(362, 60);
            this.CapName.TabIndex = 42;
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
            this.Ok.Location = new System.Drawing.Point(395, 891);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(191, 76);
            this.Ok.TabIndex = 9;
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
            this.Annuler.Location = new System.Drawing.Point(33, 891);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(182, 76);
            this.Annuler.TabIndex = 9;
            this.Annuler.Text = "Annuler";
            this.Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Modifier_composant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(616, 992);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.CapRef);
            this.Controls.Add(this.CapName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.inst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modifier_composant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker inst;
        private Guna.UI2.WinForms.Guna2DateTimePicker modif;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RoundedTextBox CapName;
        private RoundedTextBox CapRef;
        private RoundedButton Annuler;
        private RoundedButton Ok;
        private System.Windows.Forms.Label label5;
        private RoundedTextBox notes;
    }
}