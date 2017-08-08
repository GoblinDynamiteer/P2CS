using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
            this.Text = Program.name;

        }

        private void btnPasswordOK_Click(object sender, EventArgs e)
        {
            /* Bygg check för lösenord */
            frmMain mainWindow = new frmMain();
            mainWindow.Show();
            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.QuitProgram();
        }

        private void frmPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.QuitProgram();
        }
    }
}
