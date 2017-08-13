using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmPassword : Form
    {
        string storedPasswordFile = "login.pwd";
        string defaultPassword = "123";
        int key;
        string password;

        public frmPassword()
        {
            InitializeComponent();
            this.Text = Program.name;

            /* Genererade första lösenordet för programmet */
            /*
            key = Password.GenerateRandomKey(100, 300, new Random());
            password = Password.EncryptText("TigrarÄger123!", key);
            Password.SaveToFile(storedPasswordFile, password, key); */

            if (!Password.LoadFromFile(
                storedPasswordFile, out key, out password))
            {
                password = defaultPassword;
                key = 0;
            }
        }

        private void btnPasswordOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == Password.DecryptText(password, key))
            {
                frmMain mainWindow = new frmMain();
                mainWindow.Show();
                this.Visible = false;
            }

            else
            {
                lblPasswordInfo.ForeColor = System.Drawing.Color.DarkRed;
                lblPasswordInfo.Text = "Fel lösenord!";
            }
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
