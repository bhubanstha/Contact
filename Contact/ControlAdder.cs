using System;
using System.Linq;
using System.Windows.Forms;
using Contact.UserControls;
using Win.Carousel;
using System.Drawing;

namespace Contact
{
    public enum Feature
    {
        Home,
        Contact,
        NewContact,
        NewGroup,
        PersonProfile,
        ChangePassword,
        MyProfile
    }

    public sealed class ControlAdder
    {
        private static Panel container;
        private static ControlAdder instance = null;
        private static readonly object padlock = new object();

        public static ctrlAddNewContact ctrlNewContact = new ctrlAddNewContact();
        public static ctrlGroup ctrlGroup = new ctrlGroup();
        public static ctrlPersonList ctrlPersonList = new ctrlPersonList();
        public static ctrlPersonProfile ctrlPersonProfile = new ctrlPersonProfile();
        public static Carousel ctrlCarousel = new Carousel();
        public static ctrlChangePassword ctrlChangePassword = new ctrlChangePassword();
        public static ctrlMyProfile ctrlMyProfile = new ctrlMyProfile();
        public Panel MenuContainer;
        public Button btnHome;
        public Button btnContacts;
        public Button btnNewContact;
        public Button btnNewGroup;
        public string UserName = "";
        ControlAdder()
        {
        }

        public static ControlAdder Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            ctrlNewContact.Dock = DockStyle.Fill;
                            ctrlGroup.Dock = DockStyle.Fill;
                            ctrlPersonList.Dock = DockStyle.Fill;
                            ctrlPersonProfile.Dock = DockStyle.Fill;
                            ctrlChangePassword.Dock = DockStyle.Fill;
                            ctrlMyProfile.Dock = DockStyle.Fill;
                            instance = new ControlAdder();
                        }
                    }
                }
                return instance;
            }
        }

        public void Add(ref Panel ctrlContainer, Feature feature)
        {
            container = ctrlContainer;
            foreach (UserControl ctrl in ctrlContainer.Controls.OfType<UserControl>())
            {
                ctrlContainer.Controls.Remove(ctrl);
            }
            switch (feature)
            {
                case Feature.Home:
                    ctrlCarousel.Add(ctrlContainer);
                    break;
                case Feature.Contact:
                    ctrlPersonList.MyContainer = ctrlContainer;
                    ctrlContainer.Controls.Add(ctrlPersonList);
                    break;
                case Feature.NewContact:
                    ctrlContainer.Controls.Add(ctrlNewContact);
                    ctrlNewContact.MyContainer = ctrlContainer;
                    break;
                case Feature.NewGroup:
                    ctrlContainer.Controls.Add(ctrlGroup);
                    break;
                case Feature.PersonProfile:
                    ctrlContainer.Controls.Add(ctrlPersonProfile);
                    break;
                case Feature.ChangePassword:
                    ctrlContainer.Controls.Add(ctrlChangePassword);
                    break;
                case Feature.MyProfile:
                    ctrlContainer.Controls.Add(ctrlMyProfile);
                    break;
                default:
                    ctrlCarousel.Add(ctrlContainer);
                    break;
            }
            
        }


        public void PaintButton(object sender, EventArgs e)
        {
            foreach (Button button in this.MenuContainer.Controls.OfType<Button>())
            {
                button.BackColor = Color.Transparent;
            }
            if (sender != null)
            {
                Button btn = sender as Button;
                btn.BackColor = Color.FromArgb(192, 0, 0);
            }
        }
    }
}
