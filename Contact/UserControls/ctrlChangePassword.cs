using System;
using System.Windows.Forms;
using Contact.CRUD;

namespace Contact.UserControls
{
    public partial class ctrlChangePassword : UserControl
    {
        public ctrlChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtPwd.Text, txtConPwd.Text) && txtPwd.Text != "" && txtConPwd.Text != "")
            {
                ControlAdder ctrl = ControlAdder.Instance;
                UserCrud uc = new UserCrud();
                int i = uc.ChangePassword(txtPwd.Text, ctrl.UserName);
                if (i > 0)
                {
                    MessageBox.Show("Password updated", "My Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConPwd.Text = txtPwd.Text = "";
                    txtPwd.Focus();
                }
            }
            else if (txtPwd.Text == "")
            {
                txtPwd.Focus();
            }
            else if (txtConPwd.Text == "")
            {
                txtConPwd.Focus();
            }
            else
            {
                txtConPwd.Text = "";
                txtConPwd.Focus();
            }
        }
    }
}
