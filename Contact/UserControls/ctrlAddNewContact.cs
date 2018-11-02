using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Contact.Model;
using Contact.CRUD;

namespace Contact.UserControls
{
    public partial class ctrlAddNewContact : UserControl
    {
        Image img;
        GroupCRUD gc = new GroupCRUD();
        public Panel MyContainer;
        public ctrlAddNewContact(ref Panel pnlCtrlContainer)
        {
            InitializeComponent();
            foreach (UserControl ctrl in pnlCtrlContainer.Controls.OfType<UserControl>())
            {
                pnlCtrlContainer.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            this.ActiveControl = txtName;
        }

        public ctrlAddNewContact()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                FullName = txtName.Text,
                Address = txtAddress.Text,
                PrimaryEmail = txtEmail.Text,
                GroupId = Convert.ToInt32(ddlGroup.SelectedValue),
                Mobile1 = txtMobile1.Text,
                Mobile2 = txtMobile2.Text,
                Relation = txtRelation.Text,
                BirthDay = Convert.ToDateTime(dtpBirthday.Text),
                Company = txtCompany.Text,
                Title = txtTitle.Text,
                Website = txtWebsite.Text,
                ProfEmail = txtProEmail.Text,
                Telephone1 = txtProTelephone1.Text,
                Telephone2 = txtProTelephone2.Text,
                ProfMobile1 = txtProMobile1.Text,
                ProfMobile2 = txtProMobile2.Text,
                Fax = txtProFax.Text,
                Note = txtNote.Text,
                Skype = txtSkype.Text,
                WindowsLive = txtWinLive.Text,
                Yahoo = txtYahoo.Text,
                Hangout = txtHangout.Text,
                Gmail = txtGmail.Text,
                Facebook = txtFacebook.Text
            };

            img = picImage.Image;
            if (img != null)
            {
                string imgTag = picImage.Tag.ToString();
                if (imgTag == lblImageName.Text)
                {
                    person.ImageName = imgTag;
                }
                else
                {
                    string fileName = Guid.NewGuid().ToString("N") + ".jpg";
                    person.ImageName = fileName;
                    img.Save(AppDomain.CurrentDomain.BaseDirectory + "\\profile\\" + fileName);
                }
            }
            PersonCrud pcrud = new PersonCrud();
            int id = 0;
            int.TryParse(lblId.Text, out id);
            if (id > 0)
            {
                pcrud.Update(person, id);
            }
            else
            {
                int i = pcrud.Add(person);
            }

            ControlAdder ctrl = ControlAdder.Instance;
            ctrl.Add(ref MyContainer, Feature.Contact);
            ControlAdder.ctrlPersonList.AddContact();
            ctrl.PaintButton(ctrl.btnContacts, null);
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(ofd.FileName);
                picImage.Image = img;
                picImage.Tag = ofd.FileName;
            }
        }


        public void LoadDetail(DataRow person)
        {
            txtName.Text = person["FullName"].ToString();
            txtAddress.Text = person["Address"].ToString();
            txtEmail.Text = person["PrimaryEmail"].ToString();
            ddlGroup.Text = person["Group"].ToString();
            txtMobile1.Text = person["Mobile1"].ToString();
            txtMobile2.Text = person["Mobile2"].ToString();
            txtRelation.Text = person["Relation"].ToString();
            string bd = person["Birthday"].ToString();
            DateTime dt;
            if (!string.IsNullOrEmpty(bd))
            {
                dt = DateTime.Parse(bd);
                dtpBirthday.Text = dt.ToString("dd/MMM/yyyy");
            }
            txtCompany.Text = person["Company"].ToString();
            txtTitle.Text = person["Title"].ToString();
            txtWebsite.Text = person["Website"].ToString();
            txtProEmail.Text = person["ProfEmail"].ToString();
            txtProTelephone1.Text = person["Telephone1"].ToString();
            txtProTelephone2.Text = person["Telephone2"].ToString();
            txtProMobile1.Text = person["ProfMobile1"].ToString();
            txtProMobile2.Text = person["ProfMobile2"].ToString();
            txtProFax.Text = person["Fax"].ToString();
            txtNote.Text = person["Note"].ToString();
            txtSkype.Text = person["Skype"].ToString();
            txtWinLive.Text = person["windowsLive"].ToString();
            txtYahoo.Text = person["Yahoo"].ToString();
            txtHangout.Text = person["Hangout"].ToString();
            txtGmail.Text = person["Gmail"].ToString();
            txtFacebook.Text = person["Facebook"].ToString();
            lblId.Text = person["Id"].ToString();
            string imageName = person["ProfileImage"].ToString();
            Image image;
            if (!string.IsNullOrEmpty(imageName))
            {
                try
                {
                    image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\profile\\" + imageName);
                    lblImageName.Text = imageName;
                }
                catch
                {
                    image = Properties.Resources.photo;
                    picImage.Tag = "photo.jpg";
                }
            }
            else
            {
                image = Properties.Resources.photo;
                picImage.Tag = "photo.jpg";
            }
            picImage.Image = image;
            picImage.Tag = imageName;
        }

        public void Init()

        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            ddlGroup.Text = "";
            txtMobile1.Text = "";
            txtMobile2.Text = "";
            txtRelation.Text = "";
            dtpBirthday.Text = DateTime.Now.AddYears(-15).ToString();
            txtCompany.Text = "";
            txtTitle.Text = "";
            txtWebsite.Text = "";
            txtProEmail.Text = "";
            txtProTelephone1.Text = "";
            txtProTelephone2.Text = "";
            txtProMobile1.Text = "";
            txtProMobile2.Text = "";
            txtProFax.Text = "";
            txtNote.Text = "";
            txtSkype.Text = "";
            txtWinLive.Text = "";
            txtYahoo.Text = "";
            txtHangout.Text = "";
            txtGmail.Text = "";
            txtFacebook.Text = "";
            lblId.Text = "";
            lblImageName.Text = "";
            Image image = Properties.Resources.photo;
            picImage.Image = image;
            picImage.Tag = "photo.jpg";
        }
        private void ctrlAddNewContact_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        public void LoadGroup()
        {
            DataTable tbl = gc.GetAllGroup();
            ddlGroup.ValueMember = "Id";
            ddlGroup.DisplayMember = "Name";
            ddlGroup.DataSource = tbl;
        }
        
    }
}
