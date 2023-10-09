namespace macdoc
{
    partial class ConfirmAction
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Users = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForgotPW = new System.Windows.Forms.Label();
            this.ShowPassword = new macdoc.RoundedButton();
            this.Ok = new macdoc.RoundedButton();
            this.iconButton5 = new macdoc.RoundedButton();
            this.PassWord = new macdoc.RoundedTextBox();
            this.roundedButton7 = new macdoc.RoundedButton();
            this.roundedButton1 = new macdoc.RoundedButton();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.AllowDrop = true;
            this.Users.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.Users.Location = new System.Drawing.Point(147, 299);
            this.Users.MaxDropDownItems = 28;
            this.Users.Name = "Users";
            this.Users.ShadowDecoration.BorderRadius = 8;
            this.Users.Size = new System.Drawing.Size(403, 36);
            this.Users.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Users.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ingénieure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 104);
            this.label3.TabIndex = 48;
            this.label3.Text = "La modification sera executée sous le nom de:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPW
            // 
            this.ForgotPW.AutoSize = true;
            this.ForgotPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPW.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPW.ForeColor = System.Drawing.Color.White;
            this.ForgotPW.Location = new System.Drawing.Point(196, 511);
            this.ForgotPW.Name = "ForgotPW";
            this.ForgotPW.Size = new System.Drawing.Size(307, 39);
            this.ForgotPW.TabIndex = 50;
            this.ForgotPW.Text = "Mot de passe oublié ?";
            this.ForgotPW.MouseLeave += new System.EventHandler(this.ForgotPW_MouseLeave);
            this.ForgotPW.MouseHover += new System.EventHandler(this.ForgotPW_MouseHover);
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.Color.White;
            this.ShowPassword.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.ShowPassword.ForeColor = System.Drawing.Color.Black;
            this.ShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ShowPassword.IconColor = System.Drawing.Color.Black;
            this.ShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ShowPassword.IconSize = 40;
            this.ShowPassword.Location = new System.Drawing.Point(470, 430);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Padding = new System.Windows.Forms.Padding(10, 13, 10, 10);
            this.ShowPassword.Size = new System.Drawing.Size(80, 48);
            this.ShowPassword.TabIndex = 49;
            this.ShowPassword.Tag = "Triage";
            this.ShowPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.ShowPassword, "Afficher le mot de passe");
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
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
            this.Ok.Location = new System.Drawing.Point(419, 604);
            this.Ok.Name = "Ok";
            this.Ok.Padding = new System.Windows.Forms.Padding(10);
            this.Ok.Size = new System.Drawing.Size(217, 76);
            this.Ok.TabIndex = 46;
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
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(54, 604);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton5.Size = new System.Drawing.Size(217, 76);
            this.iconButton5.TabIndex = 47;
            this.iconButton5.Text = "Annuler";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.Animated = true;
            this.PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWord.DefaultText = "";
            this.PassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassWord.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.Black;
            this.PassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassWord.Location = new System.Drawing.Point(147, 431);
            this.PassWord.Margin = new System.Windows.Forms.Padding(5);
            this.PassWord.Name = "PassWord";
            this.PassWord.Padding = new System.Windows.Forms.Padding(10);
            this.PassWord.PasswordChar = '●';
            this.PassWord.PlaceholderText = "";
            this.PassWord.SelectedText = "";
            this.PassWord.Size = new System.Drawing.Size(403, 45);
            this.PassWord.TabIndex = 45;
            this.PassWord.TextOffset = new System.Drawing.Point(10, 0);
            this.PassWord.UseSystemPasswordChar = true;
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.Red;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.IconChar = FontAwesome.Sharp.IconChar.X;
            this.roundedButton7.IconColor = System.Drawing.Color.White;
            this.roundedButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roundedButton7.IconSize = 28;
            this.roundedButton7.Location = new System.Drawing.Point(630, 12);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Padding = new System.Windows.Forms.Padding(10);
            this.roundedButton7.Size = new System.Drawing.Size(50, 50);
            this.roundedButton7.TabIndex = 0;
            this.roundedButton7.UseVisualStyleBackColor = false;
            this.roundedButton7.Click += new System.EventHandler(this.roundedButton7_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roundedButton1.Enabled = false;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.roundedButton1.IconColor = System.Drawing.Color.Black;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.IconSize = 68;
            this.roundedButton1.Location = new System.Drawing.Point(307, 21);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(90, 93);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // ConfirmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(692, 719);
            this.Controls.Add(this.ForgotPW);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.roundedButton7);
            this.Controls.Add(this.roundedButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User\'s profile";
            this.Load += new System.EventHandler(this.ConfirmAction_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton roundedButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private RoundedButton roundedButton7;
        private Guna.UI2.WinForms.Guna2ComboBox Users;
        private RoundedTextBox PassWord;
        private RoundedButton Ok;
        private RoundedButton iconButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedButton ShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ForgotPW;
    }
}