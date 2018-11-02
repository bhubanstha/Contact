using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Contact.CRUD;

namespace Contact
{
    public partial class frmResetPassword : Form
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar
        UserCrud userCrud = new UserCrud();

        public frmResetPassword()
        {
            InitializeComponent();
            label1.MouseDown += move_window;
        }

        #region Form Move
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close1;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtUserName.Focus();
                return;
            }
            DataTable tbl = userCrud.GetUser(txtUserName.Text.Trim());
            if (tbl.Rows.Count > 0)
            {
                if (string.Equals(txtNewPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
                {
                    userCrud.ChangePassword(txtConfirmPassword.Text, txtUserName.Text);
                }
                else
                {
                    MessageBox.Show("New password and confirmation password didn't matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User with provided user name not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
