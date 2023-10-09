using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace macdoc
{
    public partial class UserProfile : Form
    {
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

      
        public UserProfile()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            this.Location = new Point(Cursor.Position.X-this.Width, Cursor.Position.Y);

        }

        private void Activier_MouseHover(object sender, EventArgs e)
        {
            Activier.ForeColor = Color.CornflowerBlue;
        }

        private void Activier_MouseLeave(object sender, EventArgs e)
        {
            Activier.ForeColor = Color.White;

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            User user = null;
            DBHelper.SelectAllUsers(Users);
            Users.Items.Remove("Tout");

            if (DBHelper.SelectAdmin()!=null)
            {
               user = DBHelper.SelectAdmin();

            }

            if (user!=null)
            {
                UserName.Text = user.Name + " " + user.LastName;
                Phone.Text = user.PhoneNumber; 
            }

        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void UserProfile_Leave(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Activier_Click(object sender, EventArgs e)
        {

        }
    }
}
