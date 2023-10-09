using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class ConfirmAction : Form
    {
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        const char CHR_ = '\0';
        bool ShowPW = false;
        public event EventHandler Confirmed;
        public User user;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        public ConfirmAction()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            ShowInTaskbar  = false;
            this.Owner = new ModifierMachine(null);
        }

        private void ConfirmAction_Load(object sender, EventArgs e)
        {



        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmAction_Load_1(object sender, EventArgs e)
        {
            m_aeroEnabled = false;

            try
            {
                DBHelper.SelectAllUsers(Users);
                Users.Items.Remove("Tout");

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ForgotPW_MouseHover(object sender, EventArgs e)
        {
            ForgotPW.ForeColor = Color.CornflowerBlue;

        }

        private void ForgotPW_MouseLeave(object sender, EventArgs e)
        {
            ForgotPW.ForeColor = Color.White;

        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (!ShowPW)
            {
                PassWord.UseSystemPasswordChar = false;
                PassWord.PasswordChar = CHR_;
                ShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                toolTip1.SetToolTip(this.ShowPassword, "Masquer le mot de passe");
                ShowPW = true;
            }
            else
            {
                PassWord.UseSystemPasswordChar = true;
                PassWord.PasswordChar = '●';

                ShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                toolTip1.SetToolTip(this.ShowPassword, "Afficher le mot de passe");
                ShowPW = false;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string name = Users.SelectedItem.ToString(), password = PassWord.Text;

            User user = DBHelper.ReturnUser(name, password);

            if (user !=null)
            {
                OnRefreshRequested(EventArgs.Empty);
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Mot de passe incorrect! ", "Mot de passe incorrect", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);

                if (result == DialogResult.Cancel)
                {
                    Close();
                }
            }

            

        }
        public virtual void OnRefreshRequested(EventArgs e)
        {

            EventHandler eh = Confirmed;

            if (eh != null)
            {

                eh(this, e);
            }
        }
    }
}
