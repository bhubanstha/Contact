using System;
using System.Data;
using System.Windows.Forms;
using Contact.CRUD;

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
            DataTable tbl = uc.GetUser(ctrl.UserName);
            if (tbl.Rows.Count > 0)
            {
                lblName.Text = tbl.Rows[0]["Name"].ToString();
                lblEmail.Text = tbl.Rows[0]["Email"].ToString();
                lblMobile.Text = tbl.Rows[0]["Mobile"].ToString();
                lblMobile2.Text = tbl.Rows[0]["Mobile1"].ToString();
                lblAddress.Text = tbl.Rows[0]["Address"].ToString();
                lblBirthday.Text = tbl.Rows[0]["Birthday"].ToString();
            }
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
