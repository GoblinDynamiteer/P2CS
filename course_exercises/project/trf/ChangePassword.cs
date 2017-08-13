using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();

            this.Text = "Ändra lösenord";
        }


        private void checkBoxShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            textBoxNewPassword.PasswordChar = 
                checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                lblPasswordInfo.ForeColor = System.Drawing.Color.DarkRed;
                lblPasswordInfo.Text = "Lösenordet får inte vara tomt!";
            }

            else
            {
                int key = Password.GenerateRandomKey();
                string newPass = Password.EncryptText(textBoxNewPassword.Text, key);

                if (Password.SaveToFile(Program.storedPasswordFile, newPass, key))
                {
                    MessageBox.Show("Lösenordet uppdaterades");
                }

                else
                {
                    MessageBox.Show("Sparning av nytt lösenord misslyckades!");
                }

                this.Close();
            }
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
