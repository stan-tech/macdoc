namespace macdoc
{
    partial class BuyHistory
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
            this.Syn_types = new macdoc.RoundedPanel();
            this.Nouveaux = new FontAwesome.Sharp.IconButton();
            this.NC = new FontAwesome.Sharp.IconButton();
            this.Remp = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Compos = new macdoc.RoundedGrid();
            this.iconButton2 = new macdoc.RoundedButton();
            this.Search = new macdoc.RoundedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.roundedButton2 = new macdoc.RoundedButton();
            this.Syn_types.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.SuspendLayout();
            // 
            // Syn_types
            // 
            this.Syn_types.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Syn_types.BackColor = System.Drawing.Color.Transparent;
            this.Syn_types.Controls.Add(this.Nouveaux);
            this.Syn_types.Controls.Add(this.NC);
            this.Syn_types.Controls.Add(this.Remp);
            this.Syn_types.Location = new System.Drawing.Point(18, 22);
            this.Syn_types.Name = "Syn_types";
            this.Syn_types.Size = new System.Drawing.Size(1752, 123);
            this.Syn_types.TabIndex = 12;
            // 
            // Nouveaux
            // 
            this.Nouveaux.BackColor = System.Drawing.Color.Indigo;
            this.Nouveaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouveaux.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Nouveaux.ForeColor = System.Drawing.Color.White;
            this.Nouveaux.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.Nouveaux.IconColor = System.Drawing.Color.White;
            this.Nouveaux.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Nouveaux.IconSize = 100;
            this.Nouveaux.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Nouveaux.Location = new System.Drawing.Point(604, -2);
            this.Nouveaux.Name = "Nouveaux";
            this.Nouveaux.Padding = new System.Windows.Forms.Padding(10);
            this.Nouveaux.Size = new System.Drawing.Size(519, 126);
            this.Nouveaux.TabIndex = 8;
            this.Nouveaux.Tag = "Triage";
            this.Nouveaux.Text = "Nouveaux       210";
            this.Nouveaux.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nouveaux.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nouveaux.UseVisualStyleBackColor = false;
            this.Nouveaux.Click += new System.EventHandler(this.Nouveaux_Click);
            // 
            // NC
            // 
            this.NC.BackColor = System.Drawing.Color.Indigo;
            this.NC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NC.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.NC.ForeColor = System.Drawing.Color.White;
            this.NC.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.NC.IconColor = System.Drawing.Color.White;
            this.NC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NC.IconSize = 100;
            this.NC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NC.Location = new System.Drawing.Point(-5, -2);
            this.NC.Name = "NC";
            this.NC.Padding = new System.Windows.Forms.Padding(10);
            this.NC.Size = new System.Drawing.Size(612, 126);
            this.NC.TabIndex = 8;
            this.NC.Tag = "Triage";
            this.NC.Text = "En usage       534";
            this.NC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NC.UseVisualStyleBackColor = false;
            this.NC.Click += new System.EventHandler(this.NC_Click);
            // 
            // Remp
            // 
            this.Remp.BackColor = System.Drawing.Color.Indigo;
            this.Remp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remp.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Remp.ForeColor = System.Drawing.Color.White;
            this.Remp.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.Remp.IconColor = System.Drawing.Color.White;
            this.Remp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Remp.IconSize = 100;
            this.Remp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Remp.Location = new System.Drawing.Point(1120, -2);
            this.Remp.Name = "Remp";
            this.Remp.Padding = new System.Windows.Forms.Padding(10);
            this.Remp.Size = new System.Drawing.Size(648, 126);
            this.Remp.TabIndex = 8;
            this.Remp.Tag = "Triage";
            this.Remp.Text = "Remplacés        300";
            this.Remp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Remp.UseVisualStyleBackColor = false;
            this.Remp.Click += new System.EventHandler(this.Remp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Syn_types);
            this.panel1.Controls.Add(this.Compos);
            this.panel1.Location = new System.Drawing.Point(12, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1789, 970);
            this.panel1.TabIndex = 13;
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
            this.Compos.Location = new System.Drawing.Point(18, 142);
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
            this.Compos.Size = new System.Drawing.Size(1752, 798);
            this.Compos.Style = MetroFramework.MetroColorStyle.Teal;
            this.Compos.TabIndex = 73;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(1105, 89);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton2.Size = new System.Drawing.Size(80, 55);
            this.iconButton2.TabIndex = 74;
            this.iconButton2.Tag = "Triage";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
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
            this.Search.Location = new System.Drawing.Point(645, 92);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderText = "";
            this.Search.SelectedText = "";
            this.Search.Size = new System.Drawing.Size(521, 50);
            this.Search.TabIndex = 76;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(793, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 45);
            this.label3.TabIndex = 75;
            this.label3.Text = "Rechercher";
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
            this.roundedButton1.TabIndex = 74;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.roundedButton2.IconColor = System.Drawing.Color.White;
            this.roundedButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton2.IconSize = 30;
            this.roundedButton2.Location = new System.Drawing.Point(51, 30);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(10);
            this.roundedButton2.Size = new System.Drawing.Size(55, 55);
            this.roundedButton2.TabIndex = 74;
            this.roundedButton2.Tag = "Triage";
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // BuyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1813, 1156);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyHistory";
            this.Load += new System.EventHandler(this.BuyHistory_Load);
            this.Syn_types.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel Syn_types;
        private FontAwesome.Sharp.IconButton NC;
        private FontAwesome.Sharp.IconButton Remp;
        private System.Windows.Forms.Panel panel1;
        public RoundedGrid Compos;
        private RoundedButton iconButton2;
        public RoundedTextBox Search;
        private System.Windows.Forms.Label label3;
        private RoundedButton roundedButton1;
        private FontAwesome.Sharp.IconButton Nouveaux;
        private RoundedButton roundedButton2;
    }
}