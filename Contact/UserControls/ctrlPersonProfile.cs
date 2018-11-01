using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Contact.UserControls
{
    public partial class ctrlPersonProfile : UserControl
    {
        Panel MyContainer;
        DataRow person;
       
        public ctrlPersonProfile()
        {
            InitializeComponent();
        }

        public void ShowDetail(DataRow person, ref Panel pnlContainer)
        {
            MyContainer = pnlContainer;
            this.person = person;
            lblName.Text = person["FullName"].ToString();
            lblAddress.Text = person["Address"].ToString();
            lblEmail.Text = person["PrimaryEmail"].ToString();
            lblGroup.Text = person["Group"].ToString();
            lblMobile.Text = person["Mobile1"].ToString();
            lblMobile2.Text = person["Mobile2"].ToString();
            lblRelation.Text = person["Relation"].ToString();
            string bd = person["Birthday"].ToString();
            DateTime dt;
            if (!string.IsNullOrEmpty(bd))
            {
                dt = DateTime.Parse(bd);
                lblBirthday.Text = dt.ToString("dd/MMM/yyyy");
            }            
            lblCompany.Text = person["Company"].ToString();
            lblTitle.Text = person["Title"].ToString();
            lblWebsite.Text = person["Website"].ToString();
            lblProfEmail.Text = person["ProfEmail"].ToString();
            lblProfTelephone1.Text = person["Telephone1"].ToString();
            lblProfTelephone2.Text = person["Telephone2"].ToString();
            lblProfMobile1.Text = person["ProfMobile1"].ToString();
            lblProfMobile2.Text = person["ProfMobile2"].ToString();
            lblFax.Text = person["Fax"].ToString();
            txtNote.Text = person["Note"].ToString();
            lblSkype.Text = person["Skype"].ToString();
            lblWindowsLive.Text = person["windowsLive"].ToString();
            lblYahoo.Text = person["Yahoo"].ToString();
            lblHangout.Text = person["Hangout"].ToString();
            lblGmail.Text = person["Gmail"].ToString();
            lblFacebook.Text = person["Facebook"].ToString();
            
            string imageName = person["ProfileImage"].ToString();
            Image image;
            if (!string.IsNullOrEmpty(imageName))
            {
                try
                {
                    image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\profile\\" + imageName);
                }
                catch
                {
                    image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\profile\\EE306F1B79D542BF9A58F6BAFDC1F556.jpg");
                }
                picProfile.Image = image;
            }
            else
            {
                image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\profile\\EE306F1B79D542BF9A58F6BAFDC1F556.jpg");
                picProfile.Image = image;
            }
        }
        private void picLocation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblAddress.Text))
            {
                frmGMap gmap = new frmGMap(lblAddress.Text.Trim());
                gmap.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlAdder ctrl = ControlAdder.Instance;
            ctrl.Add(ref MyContainer, Feature.NewContact);
            ControlAdder.ctrlNewContact.LoadDetail(person);
            ctrl.PaintButton(ctrl.btnNewContact, null);
            ControlAdder.ctrlNewContact.lblHeader.Text = "Edit Contact";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControlAdder ctrl = ControlAdder.Instance;
            ctrl.Add(ref MyContainer, Feature.Contact);
        }
    }
}
