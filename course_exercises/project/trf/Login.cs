using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmPassword : Form
    {
        string defaultPassword = "123";
        int key;
        string password;

        frmMain mainWindow; // Programmets huvudfönster

        /* Konstruktor */
        public frmPassword()
        {
            InitializeComponent();
            this.Text = Program.name; // Titel

            textBoxPassword.Select(); // Sätt markör i textrutan

            /* Försöker ladda in lösenordet från lösenordsfilen,
             * Vid misslyckande sätts lösenordet till standard */
            if (!Password.LoadFromFile(
                Program.storedPasswordFile, out key, out password))
            {
                password = defaultPassword;
                key = 0;
            }
        }

        /* Event-metod för "OK"-knappen */
        private void btnPasswordOK_Click(object sender, EventArgs e)
        {
            /* Om inskrivet lösenord stämmer */
            if (textBoxPassword.Text == 
                Password.DecryptText(password, key))
            {
                mainWindow = new frmMain();
                mainWindow.Show();    // Visa huvudfönster
                this.Visible = false; // Göm inloggningsrutan
            }

            else // Fel lösenord inskrivet
            {
                /* Visar mörkrött felmeddelande */
                lblPasswordInfo.ForeColor = System.Drawing.Color.DarkRed;
                lblPasswordInfo.Text = "Fel lösenord!";

                textBoxPassword.Select();
            }
        }

        /* Event-metod för "Avsluta"-knappen */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.QuitProgram(); // Stäng av programmet
        }

        /* Event-metod för "Krysset"-knappen */
        private void frmPassword_FormClosed(
            object sender, FormClosedEventArgs e)
        {
            Program.QuitProgram(); // Stäng av programmet
        }
    }
}
