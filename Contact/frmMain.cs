using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Contact
{
    public partial class frmMain : Form
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar
        ControlAdder ctrl = ControlAdder.Instance;
        public frmMain()
        {
            InitializeComponent();
            SetFormSize();
            this.pnlHeader.MouseDown += move_window; // binding the method to the event
            this.txtCaption.MouseDown += move_window;
            this.pnlSearchContainer.MouseDown += move_window;
            //this.picSearch.MouseDown += move_window;
            this.picUserIcon.MouseDown += move_window;
            //this.lblUserName.MouseDown += move_window;
            PaintLink();
            ctrl.MenuContainer = pnlMenu;
            ctrl.btnHome = btnHome;
            ctrl.btnContacts = btnContact;
            ctrl.btnNewContact = btnAddNew;
            ctrl.btnNewGroup = btnNewGroup;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
            PaintButton(btnHome, null);
        }



        private void SetFormSize()
        {
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(Convert.ToInt32(area.Width / 1.2), Convert.ToInt32(area.Height / 1.2));
            this.StartPosition = FormStartPosition.CenterScreen;
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

        #region Link Painter
        private void PaintLink()
        {
            btnHome.Click +=  PaintButton;
            btnContact.Click += PaintButton;
            btnAddNew.Click += PaintButton;
            btnNewGroup.Click += PaintButton;

        }

        private void PaintButton(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            foreach (Button button in this.pnlMenu.Controls.OfType<Button>())
            {
                button.BackColor = Color.Transparent;
            }
            if (sender != null)
            {
                Button btn = sender as Button;
                btn.BackColor = Color.FromArgb(192, 0, 0);
            }
           
        }
        #endregion

        #region Home Menus

        private void picToggleMenu_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            pnlMenu.Width = pnlMenu.Width == 75 ? 223 : 75;
            int i = 0;
            foreach (Button button in this.pnlMenu.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
            {
                if (pnlMenu.Width == 75)
                {
                    button.Text = "";
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    picDeveloper.Visible = true;
                    lblDeveloper.Visible = false;
                    picDeveloper.BringToFront();
                }
                else
                {
                    button.Text = Link.MainLink[i];
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    picDeveloper.Visible = false;
                    lblDeveloper.Visible = true;
                    i++;
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref pnlCtrlContainer, Feature.Home);
        }
        private void btnContact_Click(object sender, EventArgs e)
        {
            if (btnContact.BackColor != Color.FromArgb(192, 0, 0))
            {
                ctrl.Add(ref pnlCtrlContainer, Feature.Contact);
                ControlAdder.ctrlPersonList.AddContact();              
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref pnlCtrlContainer, Feature.NewContact);
            ControlAdder.ctrlNewContact.lblHeader.Text = "New Contact";
            ControlAdder.ctrlNewContact.Init();
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref pnlCtrlContainer, Feature.NewGroup);
        }

        #endregion

        #region Search
        private void picSearch_Click(object sender, EventArgs e)
        {
            lblSearchUnderline.Visible = !lblSearchUnderline.Visible;
            txtSearch.Visible = !txtSearch.Visible;
            txtSearch.Focus();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    PaintButton(btnContact, null);
                    ctrl.Add(ref pnlCtrlContainer, Feature.Contact);
                    ControlAdder.ctrlPersonList.search(txtSearch.Text);

                }
            }
        }
        #endregion

        #region Option DropDown 

        private void panel1_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = !pnlOptions.Visible;
        }

        private void pnlOptions_MouseLeave(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
        }
        private void ShowOptions(object sender, EventArgs e)
        {
            pnlOptions.Visible = !pnlOptions.Visible;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref pnlCtrlContainer, Feature.ChangePassword);
            ctrl.PaintButton(null, null);
            pnlOptions.Visible = false;
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            ctrl.Add(ref pnlCtrlContainer, Feature.MyProfile);
            ctrl.PaintButton(null, null);
            pnlOptions.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }

}
