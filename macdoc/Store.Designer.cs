﻿using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.Retirer = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Compos = new macdoc.RoundedGrid();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.roundedButton3 = new macdoc.RoundedButton();
            this.roundedButton2 = new macdoc.RoundedButton();
            this.Print = new macdoc.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.History = new macdoc.RoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.Annuler,
            this.Retirer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 124);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(222, 40);
            this.Search.Text = "Rechercher";
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Annuler.Image = ((System.Drawing.Image)(resources.GetObject("Annuler.Image")));
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(222, 40);
            this.Annuler.Text = "Ajouter";
            this.Annuler.Click += new System.EventHandler(this.Ajout_menu_click);
            // 
            // Retirer
            // 
            this.Retirer.BackColor = System.Drawing.Color.Orange;
            this.Retirer.Image = ((System.Drawing.Image)(resources.GetObject("Retirer.Image")));
            this.Retirer.Name = "Retirer";
            this.Retirer.Size = new System.Drawing.Size(222, 40);
            this.Retirer.Text = "Retirer ";
            this.Retirer.Click += new System.EventHandler(this.Retirer_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Compos);
            this.MainPanel.Location = new System.Drawing.Point(12, 116);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1789, 1024);
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
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.Compos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.Compos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Compos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Compos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Compos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Compos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Compos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(0, 35, 0, 35);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.Compos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.DefaultCellStyle = dataGridViewCellStyle28;
            this.Compos.EnableHeadersVisualStyles = false;
            this.Compos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Compos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Compos.Location = new System.Drawing.Point(16, 34);
            this.Compos.Name = "Compos";
            this.Compos.ReadOnly = true;
            this.Compos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.Compos.RowHeadersWidth = 82;
            this.Compos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(16, 55, 16, 55);
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Compos.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.Compos.RowTemplate.DividerHeight = 2;
            this.Compos.RowTemplate.Height = 203;
            this.Compos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Compos.Size = new System.Drawing.Size(1755, 971);
            this.Compos.Style = MetroFramework.MetroColorStyle.Teal;
            this.Compos.TabIndex = 60;
            this.Compos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Compos_CellMouseClick);
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
            this.roundedButton1.TabIndex = 72;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton3.BackgroundImage")));
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.roundedButton3.IconColor = System.Drawing.Color.Black;
            this.roundedButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton3.IconSize = 58;
            this.roundedButton3.Location = new System.Drawing.Point(29, 29);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.roundedButton3.Size = new System.Drawing.Size(93, 58);
            this.roundedButton3.TabIndex = 73;
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedButton2.BackgroundImage")));
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.roundedButton2.IconColor = System.Drawing.Color.Black;
            this.roundedButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton2.IconSize = 58;
            this.roundedButton2.Location = new System.Drawing.Point(164, 29);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.roundedButton2.Size = new System.Drawing.Size(93, 58);
            this.roundedButton2.TabIndex = 73;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.Print.IconColor = System.Drawing.Color.Black;
            this.Print.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Print.IconSize = 58;
            this.Print.Location = new System.Drawing.Point(302, 29);
            this.Print.Name = "Print";
            this.Print.Padding = new System.Windows.Forms.Padding(15);
            this.Print.Size = new System.Drawing.Size(93, 58);
            this.Print.TabIndex = 74;
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.roundedButton2);
            this.panel1.Controls.Add(this.History);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.roundedButton3);
            this.panel1.Location = new System.Drawing.Point(715, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 100);
            this.panel1.TabIndex = 75;
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
            this.caps.ItemHeight = 48;
            this.caps.Items.AddRange(new object[] {
            "Nouveaux",
            "En Usage",
            "Remplacés"});
            this.caps.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.Location = new System.Drawing.Point(391, 45);
            this.caps.MaxDropDownItems = 28;
            this.caps.Name = "caps";
            this.caps.ShadowDecoration.BorderRadius = 8;
            this.caps.Size = new System.Drawing.Size(302, 54);
            this.caps.TabIndex = 76;
            this.caps.SelectedIndexChanged += new System.EventHandler(this.caps_SelectedIndexChanged);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.DarkTurquoise;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.History.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.History.IconColor = System.Drawing.Color.Black;
            this.History.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.History.IconSize = 58;
            this.History.Location = new System.Drawing.Point(440, 29);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(15);
            this.History.Size = new System.Drawing.Size(93, 58);
            this.History.TabIndex = 74;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.Print_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(297, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 50);
            this.label6.TabIndex = 77;
            this.label6.Text = "État";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1813, 1156);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.caps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Store_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Compos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        public RoundedGrid Compos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Annuler;
        private System.Windows.Forms.ToolStripMenuItem Retirer;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton Print;
        private RoundedButton roundedButton3;
        private Panel panel1;
        private RoundedButton History;
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        private Label label6;
    }
}