using System;
using System.Windows.Forms;

namespace Contact
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Shown(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
        }
    }
}
