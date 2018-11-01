using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Contact.CRUD;
using System.Linq;

namespace Contact.UserControls
{
    public partial class ctrlPerson : UserControl
    {
        public Panel MyContainer;
        private ControlAdder ctrl = ControlAdder.Instance;
        public FlowLayoutPanel flowPnl;

        DataRow person;
        public ctrlPerson(DataRow row)
        {
            InitializeComponent();
            person = row;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref MyContainer, Feature.PersonProfile);
            ControlAdder.ctrlPersonProfile.ShowDetail(person, ref MyContainer);
        }

        private void OpenMap(object sender, EventArgs e)
        {
            frmGMap gmap = new frmGMap(lblAddress.Text.Trim());
            gmap.ShowDialog();
        }

        private void ctrlPerson_Load(object sender, EventArgs e)
        {
            lblName.Text = person["FullName"].ToString();
            lblEmail.Text = person["PrimaryEmail"].ToString();
            lblPhone.Text = person["Mobile1"].ToString();
            lblAddress.Text = person["Address"].ToString();
            string imageName = person["ProfileImage"].ToString();
            Image image;
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\profile\\";

            if (!string.IsNullOrEmpty(imageName))
            {
                try
                {
                    image = Image.FromFile(path + imageName);
                    picProfile.Tag = imageName;
                }
                catch
                {
                    image = Image.FromFile(path + "EE306F1B79D542BF9A58F6BAFDC1F556.jpg");
                    picProfile.Tag = "EE306F1B79D542BF9A58F6BAFDC1F556.jpg";
                }
                
            }
            else
            {
                image = Image.FromFile(path + "EE306F1B79D542BF9A58F6BAFDC1F556.jpg");
                picProfile.Tag = "EE306F1B79D542BF9A58F6BAFDC1F556.jpg";
            }
            picProfile.Image = image;
        }

        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.Image = Properties.Resources.close1;
        }

        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.Image = Properties.Resources.close;
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(person["Id"]);
            PersonCrud pc = new PersonCrud();
            pc.Delete(id);
            Control ctrl = this.ParentForm.Controls.Find("cp" + id, true).FirstOrDefault();
            if (ctrl != null)
            {
                flowPnl.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }
    }
}
