using System;
using System.Data;
using System.Windows.Forms;
using Contact.CRUD;

namespace Contact
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
    }
}
