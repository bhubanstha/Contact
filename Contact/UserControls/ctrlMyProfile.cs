using System;
using System.Data;
using System.Windows.Forms;
using Contact.CRUD;
using Contact.Model;

namespace Contact.UserControls
{
    public partial class ctrlMyProfile : UserControl
    {

        UserCrud uc = new UserCrud();
        public ctrlMyProfile()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ControlAdder ctrl = ControlAdder.Instance;
            lblName.Text = User.Name;
            lblEmail.Text = User.Email;
            lblMobile.Text = User.Mobile + ", " + User.Mobile1;
            lblAddress.Text = User.Address;
            lblBirthday.Text = User.Birthday.ToString("dd MMM yyyy");
            base.OnLoad(e);
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblAddress.Text))
            {
                frmGMap gmap = new frmGMap(lblAddress.Text.Trim());
                gmap.ShowDialog();
            }
        }
    }
}
