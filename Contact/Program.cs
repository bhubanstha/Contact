using System;
using System.Windows.Forms;

namespace Contact
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginfrm = new frmLogin();
            loginfrm.Show();
            Application.Run();
        }
    }
}
