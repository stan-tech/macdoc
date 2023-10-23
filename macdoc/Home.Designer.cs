
using CustomControls.RJControls;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace macdoc
{
    partial class Home
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

        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimate_Animation zeroitAnimate_Animation1 = new Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimate_Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tri = new FontAwesome.Sharp.IconButton();
            this.comboBoxes = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MacNum = new macdoc.RoundedLabel();
            this.CompNum = new macdoc.RoundedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.machineCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.caps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconButton2 = new macdoc.RoundedButton();
            this.Search = new macdoc.RoundedTextBox();
            this.Composants = new System.Windows.Forms.Label();
            this.Syn_types = new System.Windows.Forms.Panel();
            this.NC = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.Store = new macdoc.RoundedButton();
            this.History = new macdoc.RoundedButton();
            this.Machines = new macdoc.RoundedButton();
            this.Profile = new macdoc.RoundedButton();
            this.expand = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.collapse = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.Caplabel_anim = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.combos_anim = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.CapLabel_anim_left = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.combos_anim_left = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.expand_synthTypes = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.collapse_synthTypes = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.zeroitAnimatorEdit1 = new Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimatorEdit(this.components);
            this.metroGrid1 = new macdoc.RoundedGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.PDF = new FontAwesome.Sharp.IconButton();
            this.Palettiseur = new FontAwesome.Sharp.IconButton();
            this.accoppiatore = new FontAwesome.Sharp.IconButton();
            this.CPK = new FontAwesome.Sharp.IconButton();
            this.Tecnoferrari = new FontAwesome.Sharp.IconButton();
            this.Banc = new FontAwesome.Sharp.IconButton();
            this.Synth = new FontAwesome.Sharp.IconButton();
            this.modif_button = new FontAwesome.Sharp.IconButton();
            this.Ajout_button = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Account_tip = new System.Windows.Forms.ToolTip(this.components);
            this.MaintenanceNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.GridAnim = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.Grid_anim_left = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator(this.components);
            this.MenuButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxes.SuspendLayout();
            this.Syn_types.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caplabel_anim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combos_anim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapLabel_anim_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combos_anim_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expand_synthTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse_synthTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_anim_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tri
            // 
            this.Tri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.zeroitAnimatorEdit1.SetDecoration(this.Tri, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Tri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tri.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Tri.ForeColor = System.Drawing.Color.Black;
            this.Tri.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.Tri.IconColor = System.Drawing.Color.Black;
            this.Tri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tri.IconSize = 70;
            this.Tri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tri.Location = new System.Drawing.Point(719, 3);
            this.Tri.Name = "Tri";
            this.Tri.Size = new System.Drawing.Size(634, 76);
            this.Tri.TabIndex = 8;
            this.Tri.Tag = "Triage";
            this.Tri.Text = "Triage";
            this.Tri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tri.UseVisualStyleBackColor = false;
            this.Tri.Click += new System.EventHandler(this.Tri_Click);
            // 
            // comboBoxes
            // 
            this.comboBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxes.Controls.Add(this.label3);
            this.comboBoxes.Controls.Add(this.label2);
            this.comboBoxes.Controls.Add(this.MacNum);
            this.comboBoxes.Controls.Add(this.CompNum);
            this.comboBoxes.Controls.Add(this.label1);
            this.comboBoxes.Controls.Add(this.machineCombo);
            this.comboBoxes.Controls.Add(this.caps);
            this.zeroitAnimatorEdit1.SetDecoration(this.comboBoxes, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.comboBoxes.Location = new System.Drawing.Point(1390, 560);
            this.comboBoxes.Name = "comboBoxes";
            this.comboBoxes.Size = new System.Drawing.Size(990, 82);
            this.comboBoxes.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.zeroitAnimatorEdit1.SetDecoration(this.label3, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 45);
            this.label3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.zeroitAnimatorEdit1.SetDecoration(this.label2, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Calibri", 11.875F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Machines";
            // 
            // MacNum
            // 
            this.MacNum.BackColor = System.Drawing.Color.DarkTurquoise;
            this.zeroitAnimatorEdit1.SetDecoration(this.MacNum, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.MacNum.Font = new System.Drawing.Font("Lucida Console", 15.125F, System.Drawing.FontStyle.Bold);
            this.MacNum.ForeColor = System.Drawing.Color.Black;
            this.MacNum.Location = new System.Drawing.Point(907, -2);
            this.MacNum.Name = "MacNum";
            this.MacNum.Size = new System.Drawing.Size(80, 80);
            this.MacNum.TabIndex = 20;
            this.MacNum.Text = "23";
            this.MacNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompNum
            // 
            this.CompNum.BackColor = System.Drawing.Color.DarkTurquoise;
            this.zeroitAnimatorEdit1.SetDecoration(this.CompNum, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.CompNum.Font = new System.Drawing.Font("Lucida Console", 15.125F, System.Drawing.FontStyle.Bold);
            this.CompNum.ForeColor = System.Drawing.Color.Black;
            this.CompNum.Location = new System.Drawing.Point(352, -2);
            this.CompNum.Name = "CompNum";
            this.CompNum.Size = new System.Drawing.Size(80, 80);
            this.CompNum.TabIndex = 20;
            this.CompNum.Text = "23";
            this.CompNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.zeroitAnimatorEdit1.SetDecoration(this.label1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Calibri", 11.875F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Composants";
            // 
            // machineCombo
            // 
            this.machineCombo.AllowDrop = true;
            this.machineCombo.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.machineCombo, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.machineCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.machineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.machineCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.machineCombo.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.machineCombo.ForeColor = System.Drawing.Color.Black;
            this.machineCombo.ItemHeight = 30;
            this.machineCombo.Items.AddRange(new object[] {
            "Capteurs",
            "Courroies",
            "Moteurs",
            "Reducteurs",
            "Vérins"});
            this.machineCombo.Location = new System.Drawing.Point(573, 40);
            this.machineCombo.MaxDropDownItems = 28;
            this.machineCombo.Name = "machineCombo";
            this.machineCombo.Size = new System.Drawing.Size(317, 36);
            this.machineCombo.Sorted = true;
            this.machineCombo.TabIndex = 16;
            this.machineCombo.SelectedIndexChanged += new System.EventHandler(this.machineCombo_SelectedIndexChanged);
            // 
            // caps
            // 
            this.caps.AllowDrop = true;
            this.caps.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.caps, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.caps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.caps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caps.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caps.FocusedState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ForeColor = System.Drawing.Color.Black;
            this.caps.HoverState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ItemHeight = 30;
            this.caps.Items.AddRange(new object[] {
            "Capteurs",
            "Moteurs",
            "Reducteurs",
            "Vérins",
            "Courroies"});
            this.caps.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.caps.Location = new System.Drawing.Point(23, 40);
            this.caps.MaxDropDownItems = 28;
            this.caps.Name = "caps";
            this.caps.ShadowDecoration.BorderRadius = 8;
            this.caps.Size = new System.Drawing.Size(317, 36);
            this.caps.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.caps.TabIndex = 14;
            this.caps.SelectedIndexChanged += new System.EventHandler(this.caps_SelectedIndexChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.zeroitAnimatorEdit1.SetDecoration(this.iconButton2, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(1202, 587);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton2.Size = new System.Drawing.Size(80, 55);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Tag = "Triage";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.Animated = true;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zeroitAnimatorEdit1.SetDecoration(this.Search, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Search.DefaultText = "Rechercher...";
            this.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.Font = new System.Drawing.Font("Segoe UI", 14.125F, System.Drawing.FontStyle.Italic);
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.Location = new System.Drawing.Point(722, 590);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderText = "";
            this.Search.SelectedText = "";
            this.Search.Size = new System.Drawing.Size(528, 50);
            this.Search.TabIndex = 41;
            this.Search.TextOffset = new System.Drawing.Point(9, -2);
            this.Search.TextChanged += new System.EventHandler(this.MacName_TextChanged);
            // 
            // Composants
            // 
            this.Composants.AutoSize = true;
            this.zeroitAnimatorEdit1.SetDecoration(this.Composants, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Composants.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Composants.ForeColor = System.Drawing.Color.White;
            this.Composants.Location = new System.Drawing.Point(21, 595);
            this.Composants.Name = "Composants";
            this.Composants.Size = new System.Drawing.Size(152, 45);
            this.Composants.TabIndex = 23;
            this.Composants.Text = "Capteurs";
            // 
            // Syn_types
            // 
            this.Syn_types.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Syn_types.BackColor = System.Drawing.Color.Transparent;
            this.Syn_types.Controls.Add(this.NC);
            this.Syn_types.Controls.Add(this.Tri);
            this.zeroitAnimatorEdit1.SetDecoration(this.Syn_types, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Syn_types.Location = new System.Drawing.Point(3, 385);
            this.Syn_types.Name = "Syn_types";
            this.Syn_types.Size = new System.Drawing.Size(1364, 82);
            this.Syn_types.TabIndex = 11;
            // 
            // NC
            // 
            this.NC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
            this.zeroitAnimatorEdit1.SetDecoration(this.NC, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.NC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NC.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.NC.ForeColor = System.Drawing.Color.Black;
            this.NC.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.NC.IconColor = System.Drawing.Color.Black;
            this.NC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NC.IconSize = 70;
            this.NC.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NC.Location = new System.Drawing.Point(0, 3);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(724, 76);
            this.NC.TabIndex = 8;
            this.NC.Tag = "Triage";
            this.NC.Text = "Newcheck";
            this.NC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NC.UseVisualStyleBackColor = false;
            this.NC.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.roundedButton1);
            this.panel4.Controls.Add(this.Store);
            this.panel4.Controls.Add(this.History);
            this.panel4.Controls.Add(this.Machines);
            this.panel4.Controls.Add(this.Profile);
            this.zeroitAnimatorEdit1.SetDecoration(this.panel4, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(1880, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 123);
            this.panel4.TabIndex = 12;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Silver;
            this.zeroitAnimatorEdit1.SetDecoration(this.roundedButton1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.Transparent;
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.roundedButton1.IconColor = System.Drawing.Color.White;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.IconSize = 80;
            this.roundedButton1.Location = new System.Drawing.Point(1871, 27);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedButton1.Size = new System.Drawing.Size(88, 88);
            this.roundedButton1.TabIndex = 10;
            this.roundedButton1.Tag = "Synthesis";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // Store
            // 
            this.Store.AccessibleDescription = "Account";
            this.Store.BackColor = System.Drawing.Color.DarkGray;
            this.zeroitAnimatorEdit1.SetDecoration(this.Store, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Store.ForeColor = System.Drawing.Color.Transparent;
            this.Store.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.Store.IconColor = System.Drawing.Color.White;
            this.Store.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Store.IconSize = 80;
            this.Store.Location = new System.Drawing.Point(110, 35);
            this.Store.Name = "Store";
            this.Store.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.Store.Size = new System.Drawing.Size(80, 80);
            this.Store.TabIndex = 10;
            this.Store.Tag = "Synthesis";
            this.Store.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Store.UseVisualStyleBackColor = false;
            this.Store.Click += new System.EventHandler(this.Store_Click);
            // 
            // History
            // 
            this.History.AccessibleDescription = "Account";
            this.History.BackColor = System.Drawing.Color.DarkGray;
            this.zeroitAnimatorEdit1.SetDecoration(this.History, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.History.ForeColor = System.Drawing.Color.Transparent;
            this.History.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.History.IconColor = System.Drawing.Color.White;
            this.History.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.History.IconSize = 80;
            this.History.Location = new System.Drawing.Point(216, 34);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(10);
            this.History.Size = new System.Drawing.Size(80, 80);
            this.History.TabIndex = 10;
            this.History.Tag = "Synthesis";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Machines
            // 
            this.Machines.AccessibleDescription = "Account";
            this.Machines.BackColor = System.Drawing.Color.DarkGray;
            this.zeroitAnimatorEdit1.SetDecoration(this.Machines, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Machines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Machines.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Machines.ForeColor = System.Drawing.Color.Transparent;
            this.Machines.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Machines.IconColor = System.Drawing.Color.White;
            this.Machines.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Machines.IconSize = 80;
            this.Machines.Location = new System.Drawing.Point(320, 35);
            this.Machines.Name = "Machines";
            this.Machines.Padding = new System.Windows.Forms.Padding(10);
            this.Machines.Size = new System.Drawing.Size(80, 80);
            this.Machines.TabIndex = 10;
            this.Machines.Tag = "Synthesis";
            this.Machines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Machines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account_tip.SetToolTip(this.Machines, "Liste des machines");
            this.Machines.UseVisualStyleBackColor = false;
            this.Machines.Click += new System.EventHandler(this.Machines_Click);
            // 
            // Profile
            // 
            this.Profile.AccessibleDescription = "Account";
            this.Profile.BackColor = System.Drawing.Color.DarkGray;
            this.zeroitAnimatorEdit1.SetDecoration(this.Profile, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Profile.ForeColor = System.Drawing.Color.Transparent;
            this.Profile.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.Profile.IconColor = System.Drawing.Color.White;
            this.Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Profile.IconSize = 80;
            this.Profile.Location = new System.Drawing.Point(430, 35);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(10);
            this.Profile.Size = new System.Drawing.Size(80, 80);
            this.Profile.TabIndex = 10;
            this.Profile.Tag = "Synthesis";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account_tip.SetToolTip(this.Profile, "Compte");
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.ProfileButton_Click_1);
            // 
            // expand
            // 
            this.expand.AnimateY = false;
            this.expand.EndBounds = new System.Drawing.Rectangle(-7, 24, 428, 1723);
            this.expand.Intervall = 2;
            this.expand.StartBounds = new System.Drawing.Rectangle(-7, 24, 102, 1723);
            this.expand.StepSize = 25D;
            this.expand.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            this.expand.AnimationFinished += new System.EventHandler(this.expand_AnimationFinished);
            // 
            // collapse
            // 
            this.collapse.AnimateY = false;
            this.collapse.EndBounds = new System.Drawing.Rectangle(-7, 24, 102, 1723);
            this.collapse.Intervall = 2;
            this.collapse.StartBounds = new System.Drawing.Rectangle(-7, 24, 428, 1723);
            this.collapse.StepSize = 25D;
            this.collapse.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            this.collapse.AnimationFinished += new System.EventHandler(this.collapse_AnimationFinished);
            // 
            // Caplabel_anim
            // 
            this.Caplabel_anim.AnimateY = false;
            this.Caplabel_anim.Control = this.Composants;
            this.Caplabel_anim.EndBounds = new System.Drawing.Rectangle(455, 595, 158, 45);
            this.Caplabel_anim.Intervall = 5;
            this.Caplabel_anim.StartBounds = new System.Drawing.Rectangle(323, 595, 158, 45);
            this.Caplabel_anim.StepSize = 30D;
            this.Caplabel_anim.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // combos_anim
            // 
            this.combos_anim.AnimateY = false;
            this.combos_anim.Control = this.comboBoxes;
            this.combos_anim.EndBounds = new System.Drawing.Rectangle(723, 560, 1687, 152);
            this.combos_anim.Intervall = 5;
            this.combos_anim.StartBounds = new System.Drawing.Rectangle(591, 560, 1687, 152);
            this.combos_anim.StepSize = 30D;
            this.combos_anim.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // CapLabel_anim_left
            // 
            this.CapLabel_anim_left.AnimateY = false;
            this.CapLabel_anim_left.Control = this.Composants;
            this.CapLabel_anim_left.EndBounds = new System.Drawing.Rectangle(323, 595, 158, 45);
            this.CapLabel_anim_left.Intervall = 5;
            this.CapLabel_anim_left.StartBounds = new System.Drawing.Rectangle(455, 595, 158, 45);
            this.CapLabel_anim_left.StepSize = 30D;
            this.CapLabel_anim_left.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // combos_anim_left
            // 
            this.combos_anim_left.AnimateY = false;
            this.combos_anim_left.Control = this.comboBoxes;
            this.combos_anim_left.EndBounds = new System.Drawing.Rectangle(591, 560, 1687, 152);
            this.combos_anim_left.Intervall = 5;
            this.combos_anim_left.StartBounds = new System.Drawing.Rectangle(723, 560, 1687, 152);
            this.combos_anim_left.StepSize = 30D;
            this.combos_anim_left.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // expand_synthTypes
            // 
            this.expand_synthTypes.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // collapse_synthTypes
            // 
            this.collapse_synthTypes.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // zeroitAnimatorEdit1
            // 
            this.zeroitAnimatorEdit1.AnimationType = Zeroit.Framework.Transitions.AnimatorWithEditor.AnimationType.Transparent;
            this.zeroitAnimatorEdit1.Cursor = null;
            zeroitAnimate_Animation1.AnimateOnlyDifferences = true;
            zeroitAnimate_Animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.BlindCoeff")));
            zeroitAnimate_Animation1.LeafCoeff = 0F;
            zeroitAnimate_Animation1.MaxTime = 1F;
            zeroitAnimate_Animation1.MinTime = 0F;
            zeroitAnimate_Animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicCoeff")));
            zeroitAnimate_Animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicShift")));
            zeroitAnimate_Animation1.MosaicSize = 0;
            zeroitAnimate_Animation1.Padding = new System.Windows.Forms.Padding(0);
            zeroitAnimate_Animation1.RotateCoeff = 0F;
            zeroitAnimate_Animation1.RotateLimit = 0F;
            zeroitAnimate_Animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.ScaleCoeff")));
            zeroitAnimate_Animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.SlideCoeff")));
            zeroitAnimate_Animation1.TimeCoeff = 0F;
            zeroitAnimate_Animation1.TransparencyCoeff = 1F;
            this.zeroitAnimatorEdit1.DefaultAnimation = zeroitAnimate_Animation1;
            this.zeroitAnimatorEdit1.Editor = new Zeroit.Framework.Transitions.AnimationEditors.AnimateInput(Zeroit.Framework.Transitions.AnimatorWithEditor.AnimationType.Transparent, 30, 1689, 150, 300, zeroitAnimate_Animation1, this.Syn_types, 0, new decimal(new int[] {
                0,
                0,
                0,
                0}));
            this.zeroitAnimatorEdit1.Interval = 30;
            this.zeroitAnimatorEdit1.MaxAnimationTime = 300;
            this.zeroitAnimatorEdit1.Target = this.Syn_types;
            this.zeroitAnimatorEdit1.TargetHeight = 150;
            this.zeroitAnimatorEdit1.TargetWidth = 1689;
            this.zeroitAnimatorEdit1.TimeStep = 0.12F;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowDrop = true;
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroitAnimatorEdit1.SetDecoration(this.metroGrid1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 678);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidth = 82;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 33;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(2360, 929);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 11;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentDoubleClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            this.metroGrid1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Palettiseur);
            this.panel1.Controls.Add(this.accoppiatore);
            this.panel1.Controls.Add(this.CPK);
            this.panel1.Controls.Add(this.Tecnoferrari);
            this.panel1.Controls.Add(this.Banc);
            this.panel1.Controls.Add(this.Synth);
            this.panel1.Controls.Add(this.modif_button);
            this.panel1.Controls.Add(this.Ajout_button);
            this.zeroitAnimatorEdit1.SetDecoration(this.panel1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(2403, 376);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.zeroitAnimatorEdit1.SetDecoration(this.iconButton1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 58;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1396, 255);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(570, 97);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Tag = "Supprimer une machine";
            this.iconButton1.Text = "Supprimer une machine";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.iconButton5);
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Controls.Add(this.PDF);
            this.zeroitAnimatorEdit1.SetDecoration(this.panel3, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(1990, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 244);
            this.panel3.TabIndex = 9;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButton5.BackgroundImage")));
            this.iconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zeroitAnimatorEdit1.SetDecoration(this.iconButton5, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 140;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(275, 21);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(121, 207);
            this.iconButton5.TabIndex = 1;
            this.iconButton5.Tag = "CPK";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.CPK_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButton4.BackgroundImage")));
            this.iconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zeroitAnimatorEdit1.SetDecoration(this.iconButton4, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 140;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(138, 21);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(131, 207);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.Tag = "CPK";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.CPK_Click);
            // 
            // PDF
            // 
            this.PDF.BackColor = System.Drawing.Color.Transparent;
            this.PDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PDF.BackgroundImage")));
            this.PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zeroitAnimatorEdit1.SetDecoration(this.PDF, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDF.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.PDF.ForeColor = System.Drawing.Color.Black;
            this.PDF.IconChar = FontAwesome.Sharp.IconChar.None;
            this.PDF.IconColor = System.Drawing.Color.Black;
            this.PDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PDF.IconSize = 140;
            this.PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PDF.Location = new System.Drawing.Point(17, 21);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(115, 207);
            this.PDF.TabIndex = 1;
            this.PDF.Tag = "CPK";
            this.PDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PDF.UseVisualStyleBackColor = false;
            this.PDF.Click += new System.EventHandler(this.PDF_Click_1);
            // 
            // Palettiseur
            // 
            this.Palettiseur.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.Palettiseur, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Palettiseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Palettiseur.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Palettiseur.ForeColor = System.Drawing.Color.Black;
            this.Palettiseur.IconChar = FontAwesome.Sharp.IconChar.Pallet;
            this.Palettiseur.IconColor = System.Drawing.Color.Black;
            this.Palettiseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Palettiseur.IconSize = 140;
            this.Palettiseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Palettiseur.Location = new System.Drawing.Point(949, 203);
            this.Palettiseur.Name = "Palettiseur";
            this.Palettiseur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Palettiseur.Size = new System.Drawing.Size(400, 155);
            this.Palettiseur.TabIndex = 1;
            this.Palettiseur.Tag = "Palettiseur";
            this.Palettiseur.Text = "Palettiseur";
            this.Palettiseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Palettiseur.UseVisualStyleBackColor = false;
            this.Palettiseur.Click += new System.EventHandler(this.Palettiseur_Click);
            // 
            // accoppiatore
            // 
            this.accoppiatore.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.accoppiatore, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.accoppiatore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accoppiatore.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.accoppiatore.ForeColor = System.Drawing.Color.Black;
            this.accoppiatore.IconChar = FontAwesome.Sharp.IconChar.Grip;
            this.accoppiatore.IconColor = System.Drawing.Color.Black;
            this.accoppiatore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accoppiatore.IconSize = 140;
            this.accoppiatore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accoppiatore.Location = new System.Drawing.Point(140, 203);
            this.accoppiatore.Name = "accoppiatore";
            this.accoppiatore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.accoppiatore.Size = new System.Drawing.Size(397, 155);
            this.accoppiatore.TabIndex = 1;
            this.accoppiatore.Tag = "Accoppiatore";
            this.accoppiatore.Text = "Accoppiatore";
            this.accoppiatore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accoppiatore.UseVisualStyleBackColor = false;
            this.accoppiatore.Click += new System.EventHandler(this.accoppiatore_Click);
            // 
            // CPK
            // 
            this.CPK.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.CPK, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.CPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPK.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.CPK.ForeColor = System.Drawing.Color.Black;
            this.CPK.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.CPK.IconColor = System.Drawing.Color.Black;
            this.CPK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CPK.IconSize = 140;
            this.CPK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPK.Location = new System.Drawing.Point(949, 30);
            this.CPK.Name = "CPK";
            this.CPK.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CPK.Size = new System.Drawing.Size(400, 167);
            this.CPK.TabIndex = 1;
            this.CPK.Tag = "CPK";
            this.CPK.Text = "CPK";
            this.CPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CPK.UseVisualStyleBackColor = false;
            this.CPK.Click += new System.EventHandler(this.CPK_Click);
            // 
            // Tecnoferrari
            // 
            this.Tecnoferrari.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tecnoferrari.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.Tecnoferrari, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Tecnoferrari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tecnoferrari.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Tecnoferrari.ForeColor = System.Drawing.Color.Black;
            this.Tecnoferrari.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.Tecnoferrari.IconColor = System.Drawing.Color.Black;
            this.Tecnoferrari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tecnoferrari.IconSize = 140;
            this.Tecnoferrari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tecnoferrari.Location = new System.Drawing.Point(140, 30);
            this.Tecnoferrari.Name = "Tecnoferrari";
            this.Tecnoferrari.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Tecnoferrari.Size = new System.Drawing.Size(397, 167);
            this.Tecnoferrari.TabIndex = 1;
            this.Tecnoferrari.Tag = "Tecnoferrari";
            this.Tecnoferrari.Text = "Tecnoferrari";
            this.Tecnoferrari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tecnoferrari.UseVisualStyleBackColor = false;
            this.Tecnoferrari.Click += new System.EventHandler(this.Tecnoferrari_Click);
            // 
            // Banc
            // 
            this.Banc.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.Banc, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Banc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Banc.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Banc.ForeColor = System.Drawing.Color.Black;
            this.Banc.IconChar = FontAwesome.Sharp.IconChar.Crop;
            this.Banc.IconColor = System.Drawing.Color.Black;
            this.Banc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Banc.IconSize = 140;
            this.Banc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Banc.Location = new System.Drawing.Point(543, 30);
            this.Banc.Name = "Banc";
            this.Banc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Banc.Size = new System.Drawing.Size(400, 167);
            this.Banc.TabIndex = 1;
            this.Banc.Tag = "Banc";
            this.Banc.Text = "Banc";
            this.Banc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Banc.UseVisualStyleBackColor = false;
            this.Banc.Click += new System.EventHandler(this.Banc_Click);
            // 
            // Synth
            // 
            this.Synth.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.Synth, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Synth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Synth.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Synth.ForeColor = System.Drawing.Color.Black;
            this.Synth.IconChar = FontAwesome.Sharp.IconChar.Medapps;
            this.Synth.IconColor = System.Drawing.Color.Black;
            this.Synth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Synth.IconSize = 120;
            this.Synth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Synth.Location = new System.Drawing.Point(543, 203);
            this.Synth.Name = "Synth";
            this.Synth.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Synth.Size = new System.Drawing.Size(400, 155);
            this.Synth.TabIndex = 1;
            this.Synth.Tag = "Synthesis";
            this.Synth.Text = "Synthesis";
            this.Synth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Synth.UseVisualStyleBackColor = false;
            this.Synth.Click += new System.EventHandler(this.Synth_Click);
            // 
            // modif_button
            // 
            this.modif_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modif_button.BackColor = System.Drawing.Color.Teal;
            this.zeroitAnimatorEdit1.SetDecoration(this.modif_button, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.modif_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modif_button.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.modif_button.IconChar = FontAwesome.Sharp.IconChar.PenFancy;
            this.modif_button.IconColor = System.Drawing.Color.WhiteSmoke;
            this.modif_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modif_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modif_button.Location = new System.Drawing.Point(1396, 30);
            this.modif_button.Name = "modif_button";
            this.modif_button.Size = new System.Drawing.Size(570, 84);
            this.modif_button.TabIndex = 5;
            this.modif_button.Tag = "Modifier une machine";
            this.modif_button.Text = "Modifier une machine";
            this.modif_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modif_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modif_button.UseVisualStyleBackColor = false;
            this.modif_button.Click += new System.EventHandler(this.modif_button_Click);
            // 
            // Ajout_button
            // 
            this.Ajout_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ajout_button.BackColor = System.Drawing.Color.Teal;
            this.zeroitAnimatorEdit1.SetDecoration(this.Ajout_button, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.Ajout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajout_button.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_button.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.Ajout_button.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Ajout_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ajout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_button.Location = new System.Drawing.Point(1396, 140);
            this.Ajout_button.Name = "Ajout_button";
            this.Ajout_button.Size = new System.Drawing.Size(570, 97);
            this.Ajout_button.TabIndex = 3;
            this.Ajout_button.Tag = "Ajouter une machine";
            this.Ajout_button.Text = "Ajouter une machine";
            this.Ajout_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajout_button.UseVisualStyleBackColor = false;
            this.Ajout_button.Click += new System.EventHandler(this.Ajout_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MaintenanceNotif
            // 
            this.MaintenanceNotif.Text = "MaintenanceNotif";
            this.MaintenanceNotif.Visible = true;
            this.MaintenanceNotif.BalloonTipClicked += new System.EventHandler(this.MaintenanceNotif_BalloonTipClicked);
            this.MaintenanceNotif.Click += new System.EventHandler(this.MaintenanceNotif_BalloonTipClicked);
            this.MaintenanceNotif.DoubleClick += new System.EventHandler(this.MaintenanceNotif_BalloonTipClicked);
            this.MaintenanceNotif.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaintenanceNotif_BalloonTipClicked);
            // 
            // GridAnim
            // 
            this.GridAnim.AnimateY = false;
            this.GridAnim.Control = this.metroGrid1;
            this.GridAnim.EndBounds = new System.Drawing.Rectangle(463, 678, 1928, 1295);
            this.GridAnim.Intervall = 5;
            this.GridAnim.StartBounds = new System.Drawing.Rectangle(331, 678, 1928, 1295);
            this.GridAnim.StepSize = 30D;
            this.GridAnim.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // Grid_anim_left
            // 
            this.Grid_anim_left.AnimateY = false;
            this.Grid_anim_left.Control = this.metroGrid1;
            this.Grid_anim_left.EndBounds = new System.Drawing.Rectangle(331, 678, 1928, 1295);
            this.Grid_anim_left.Intervall = 5;
            this.Grid_anim_left.StartBounds = new System.Drawing.Rectangle(463, 678, 1928, 1295);
            this.Grid_anim_left.StepSize = 30D;
            this.Grid_anim_left.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.MenuButton, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.MenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.MenuButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.MenuButton.IconColor = System.Drawing.Color.White;
            this.MenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuButton.IconSize = 60;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(29, 292);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(66, 60);
            this.MenuButton.TabIndex = 14;
            this.MenuButton.Tag = "Synthesis";
            this.MenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitAnimatorEdit1.SetDecoration(this.pictureBox1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(2403, 1627);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxes);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Syn_types);
            this.Controls.Add(this.Composants);
            this.Controls.Add(this.metroGrid1);
            this.zeroitAnimatorEdit1.SetDecoration(this, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.comboBoxes.ResumeLayout(false);
            this.comboBoxes.PerformLayout();
            this.Syn_types.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caplabel_anim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combos_anim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapLabel_anim_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combos_anim_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expand_synthTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse_synthTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_anim_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton Tri;
        private RoundedGrid metroGrid1;
        private Panel comboBoxes;
        private Guna.UI2.WinForms.Guna2ComboBox caps;
        private Guna.UI2.WinForms.Guna2ComboBox machineCombo;
        private Label label1;
        private Label label2;
        private Label Composants;
        private Label label3;
        private RoundedButton iconButton2;
        private RoundedLabel CompNum;
        private RoundedLabel MacNum;
        public RoundedTextBox Search;
        private Panel Syn_types;
        private RoundedButton Profile;
        private FontAwesome.Sharp.IconButton NC;
        private Panel panel4;
        private RoundedButton roundedButton1;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator expand;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator collapse;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator GridAnim;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator Caplabel_anim;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator combos_anim;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator Grid_anim_left;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator CapLabel_anim_left;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator combos_anim_left;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator expand_synthTypes;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBoundsAnimator collapse_synthTypes;
        private Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimatorEdit zeroitAnimatorEdit1;
        private OpenFileDialog openFileDialog1;
        private ToolTip Account_tip;
        private RoundedButton Machines;
        private RoundedButton History;
        private NotifyIcon MaintenanceNotif;
        private RoundedButton Store;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton Palettiseur;
        private FontAwesome.Sharp.IconButton accoppiatore;
        private FontAwesome.Sharp.IconButton CPK;
        private FontAwesome.Sharp.IconButton Tecnoferrari;
        private FontAwesome.Sharp.IconButton Banc;
        private FontAwesome.Sharp.IconButton Synth;
        private FontAwesome.Sharp.IconButton modif_button;
        private FontAwesome.Sharp.IconButton Ajout_button;
        private FontAwesome.Sharp.IconButton PDF;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton MenuButton;
        private PictureBox pictureBox1;
    }
}

