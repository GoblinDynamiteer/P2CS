using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            textBoxNewPassword.PasswordChar = 
                checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Generera slumpat lösenord och sätt i textrutan för
         * nytt lösenord. */
        private void btnGenerateRandomPassword_Click(
            object sender, EventArgs e)
        {
            string gen = Password.GenerateRandomPassword();
            textBoxNewPassword.Text = gen;
            checkBoxShowPassword.Checked = true;
        }
    }
}
