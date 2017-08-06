using System;
using System.Windows.Forms;

namespace trf
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
            
            frmPassword passwordWindow = new frmPassword();
            passwordWindow.Show();

            Application.Run();
        }
    }
}
