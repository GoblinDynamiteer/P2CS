using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnPasswordOK_Click(object sender, EventArgs e)
        {
            frmMain mainWindow = new frmMain();
            mainWindow.Show();
            this.Visible = false;
        }
    }
}
