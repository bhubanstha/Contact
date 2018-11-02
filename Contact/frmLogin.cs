using System;
using System.Data;
using System.Windows.Forms;
using Contact.CRUD;
using Contact.Model;

using System.Runtime.InteropServices;

namespace Contact
{
    public partial class frmLogin : Form
    {
        User usr = User.Instance;
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar

        public frmLogin()
        {
            InitializeComponent();
            this.label1.MouseDown += move_window; // binding the method to the event
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close1;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Focus();
            }
            else if (txtpassword.Text == "")
            {
                txtpassword.Focus();
            }
            else
            {
                UserCrud ucrud = new UserCrud();
                DataTable tbl = ucrud.GetUser(txtpassword.Text, txtUserName.Text);
                if (tbl.Rows.Count > 0)
                {
                    ControlAdder ctrl = ControlAdder.Instance;
                    ctrl.UserName = tbl.Rows[0]["UserName"].ToString();
                    SetUser(tbl.Rows[0]);

                    frmMain fm = new frmMain();
                    fm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "My Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassword.Text = "";
                    txtpassword.Focus();
                }
            }
        }


        private void SetUser(DataRow row)
        {
            User.Id = Convert.ToInt32(row["Id"]);
            User.UserName = row["UserName"].ToString();
            User.Name = row["Name"].ToString();
            User.Email = row["Email"].ToString();
            User.Mobile = row["Mobile"].ToString();
            User.Mobile1 = row["Mobile1"].ToString();
            User.Address = row["Address"].ToString();
            User.Birthday = Convert.ToDateTime(row["Birthday"].ToString());
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

        private void lblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPassword frmResetPassword = new frmResetPassword();
            frmResetPassword.TopMost = true;
            frmResetPassword.ShowDialog();
        }
    }
}
