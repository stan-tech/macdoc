namespace macdoc
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.roundedButton1 = new macdoc.RoundedButton();
            this.AddUser = new macdoc.RoundedButton();
            this.UserName = new macdoc.RoundedLabel();
            this.Phone = new macdoc.RoundedLabel();
            this.Users = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roundedButton2 = new macdoc.RoundedButton();
            this.roundedButton3 = new macdoc.RoundedButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteUser = new macdoc.RoundedButton();
            this.EditUser = new macdoc.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButton6 = new macdoc.RoundedButton();
            this.roundedLabel1 = new macdoc.RoundedLabel();
            this.Activier = new System.Windows.Forms.Label();
            this.roundedButton7 = new macdoc.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton1.Enabled = false;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.roundedButton1.IconColor = System.Drawing.Color.Black;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.IconSize = 68;
            this.roundedButton1.Location = new System.Drawing.Point(21, 97);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(120, 122);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.AddUser.IconColor = System.Drawing.Color.Black;
            this.AddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddUser.IconSize = 68;
            this.AddUser.Location = new System.Drawing.Point(1043, 318);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(104, 87);
            this.AddUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.AddUser, "Ajouter un ingénieure");
            this.AddUser.UseVisualStyleBackColor = false;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(196, 82);
            this.UserName.Name = "UserName";
            this.UserName.Padding = new System.Windows.Forms.Padding(10);
            this.UserName.Size = new System.Drawing.Size(363, 58);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Name";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(196, 166);
            this.Phone.Name = "Phone";
            this.Phone.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.Phone.Size = new System.Drawing.Size(363, 67);
            this.Phone.TabIndex = 1;
            this.Phone.Text = "0561253364";
            // 
            // Users
            // 
            this.Users.AllowDrop = true;
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Users.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Users.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Users.FocusedState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Users.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Users.ForeColor = System.Drawing.Color.Black;
            this.Users.HoverState.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Users.ItemHeight = 30;
            this.Users.Items.AddRange(new object[] {
            "Capteurs",
            "Moteurs",
            "Reducteurs",
            "Vérins",
            "Courroies"});
            this.Users.ItemsAppearance.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Users.ItemsAppearance.SelectedFont = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.Users.Location = new System.Drawing.Point(831, 176);
            this.Users.MaxDropDownItems = 28;
            this.Users.Name = "Users";
            this.Users.ShadowDecoration.BorderRadius = 8;
            this.Users.Size = new System.Drawing.Size(317, 36);
            this.Users.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Users.TabIndex = 15;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.roundedButton2.IconColor = System.Drawing.Color.Black;
            this.roundedButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton2.IconSize = 38;
            this.roundedButton2.Location = new System.Drawing.Point(565, 82);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(60, 58);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton3.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.roundedButton3.IconColor = System.Drawing.Color.Black;
            this.roundedButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton3.IconSize = 38;
            this.roundedButton3.Location = new System.Drawing.Point(565, 175);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(60, 58);
            this.roundedButton3.TabIndex = 0;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.Red;
            this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUser.IconChar = FontAwesome.Sharp.IconChar.PersonCircleXmark;
            this.DeleteUser.IconColor = System.Drawing.Color.White;
            this.DeleteUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteUser.IconSize = 68;
            this.DeleteUser.Location = new System.Drawing.Point(920, 317);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(104, 87);
            this.DeleteUser.TabIndex = 0;
            this.DeleteUser.UseVisualStyleBackColor = false;
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.Color.LimeGreen;
            this.EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.EditUser.IconColor = System.Drawing.Color.White;
            this.EditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditUser.IconSize = 68;
            this.EditUser.Location = new System.Drawing.Point(787, 318);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(104, 87);
            this.EditUser.TabIndex = 0;
            this.EditUser.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status de license:";
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.roundedButton6.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.roundedButton6.IconColor = System.Drawing.Color.Black;
            this.roundedButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton6.IconSize = 38;
            this.roundedButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton6.Location = new System.Drawing.Point(21, 336);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.roundedButton6.Size = new System.Drawing.Size(442, 58);
            this.roundedButton6.TabIndex = 0;
            this.roundedButton6.Text = "Modifier le mot de passe";
            this.roundedButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.roundedButton6.UseVisualStyleBackColor = false;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.AutoSize = true;
            this.roundedLabel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.roundedLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(278, 487);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedLabel1.Size = new System.Drawing.Size(90, 59);
            this.roundedLabel1.TabIndex = 1;
            this.roundedLabel1.Text = "Test";
            this.roundedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Activier
            // 
            this.Activier.AutoSize = true;
            this.Activier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activier.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activier.ForeColor = System.Drawing.Color.White;
            this.Activier.Location = new System.Drawing.Point(400, 507);
            this.Activier.Name = "Activier";
            this.Activier.Size = new System.Drawing.Size(132, 39);
            this.Activier.TabIndex = 16;
            this.Activier.Text = "Activer ?";
            this.Activier.Click += new System.EventHandler(this.Activier_Click);
            this.Activier.MouseLeave += new System.EventHandler(this.Activier_MouseLeave);
            this.Activier.MouseHover += new System.EventHandler(this.Activier_MouseHover);
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.Red;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.IconChar = FontAwesome.Sharp.IconChar.X;
            this.roundedButton7.IconColor = System.Drawing.Color.White;
            this.roundedButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton7.IconSize = 28;
            this.roundedButton7.Location = new System.Drawing.Point(1097, 12);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Padding = new System.Windows.Forms.Padding(10);
            this.roundedButton7.Size = new System.Drawing.Size(50, 50);
            this.roundedButton7.TabIndex = 0;
            this.roundedButton7.UseVisualStyleBackColor = false;
            this.roundedButton7.Click += new System.EventHandler(this.roundedButton7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(941, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1027, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Macdoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(824, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Liste des ingénieures";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1160, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Activier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.roundedButton6);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.roundedButton7);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.roundedButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User\'s profile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.Leave += new System.EventHandler(this.UserProfile_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton roundedButton1;
        private RoundedButton AddUser;
        private RoundedLabel UserName;
        private RoundedLabel Phone;
        private Guna.UI2.WinForms.Guna2ComboBox Users;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private RoundedButton DeleteUser;
        private RoundedButton EditUser;
        private System.Windows.Forms.Label label2;
        private RoundedButton roundedButton6;
        private RoundedLabel roundedLabel1;
        private System.Windows.Forms.Label Activier;
        private RoundedButton roundedButton7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}