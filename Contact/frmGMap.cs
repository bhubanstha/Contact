using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime.InteropServices;

namespace Contact
{
    public partial class frmGMap : Form
    {
        PointLatLng point = new PointLatLng();
        string add = "Nepal";

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar
        
        
        public frmGMap(string address)
        {
            InitializeComponent();
            lblAddress.Text = address;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pnlHeader.MouseDown += new MouseEventHandler(move_window); // binding the method to the event
            this.lblAddress.MouseDown += new MouseEventHandler(move_window); // binding the method to the event
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;
            if (!String.IsNullOrEmpty(address.Trim()))
            {
                add = address.Replace(",", " ");
            }
        }

        private void frmGMap_Load(object sender, EventArgs e)
        {
            ctrlGMap.Zoom = 14;
        }

        private void frmGMap_Shown(object sender, EventArgs e)
        {
            ctrlGMap.GetPositionByKeywords(add, out point);
            ctrlGMap.MapProvider = GMapProviders.GoogleMap;
            ctrlGMap.DragButton = MouseButtons.Left;
            ctrlGMap.Position = point;
            ctrlGMap.ShowCenter = false;
            GMapOverlay markers = new GMapOverlay("marker");
            GMapMarker marker = new GMarkerGoogle(point, Properties.Resources.locationmarker);
            markers.Markers.Add(marker);
            ctrlGMap.Overlays.Add(markers);
            ctrlGMap.Zoom = 14;
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

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrlGMap.Dispose();
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.close1;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.close;
        }
    }
}
