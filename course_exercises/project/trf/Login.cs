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

        /* Konstruktor */
        public frmPassword()
        {
            InitializeComponent();
            this.Text = Program.name;

            /* Försöker ladda in lösenordet från lösenordsfilen,
             * Vid misslyckande sätts lösenordet till standard */
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
                /* Vissar rött, elakt felmeddelande vid fel lösenordsinmatning */
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
