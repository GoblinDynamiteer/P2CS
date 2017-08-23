using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmChangePassword : Form
    {
        /* Konstruktor */
        public frmChangePassword()
        {
            InitializeComponent();

            this.Text = "Ändra lösenord"; // Titel på fönstret
        }

        /* Event-metod för "Visa lösenord"-ruta */
        private void checkBoxShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            /* Sätt lösenordmaskering för textruta, 
             * '\0' visar klartext */
            textBoxNewPassword.PasswordChar = 
                checkBoxShowPassword.Checked ? '\0' : '*';
        }

        /* Event-metod för "Avbryt"-knapp */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Stäng "Ändra lösenord"-fönstret
        }

        /* Event-metod för "OK"-knapp */
        private void btnOk_Click(object sender, EventArgs e)
        {
            /* Om textrutan för nytt lösenord är tom */
            if (textBoxNewPassword.Text == "")
            {
                /* Visa felmeddelande med mörkröd text */
                lblPasswordInfo.ForeColor = System.Drawing.Color.DarkRed;
                lblPasswordInfo.Text = "Lösenordet får inte vara tomt!";
            }

            else
            {
                /* Generera en krypteringsnyckel med Passowrd-klassen */
                int key = Password.GenerateRandomKey();

                /* Kryptera det nya lösenordet med krypteringsnyckeln */
                string newPass = Password.EncryptText(
                    textBoxNewPassword.Text, key);

                /* Spara det nya lösenordet till textfil. 
                 * Metoden SaveToFile ger sanningsvärde beroende på om 
                 * skrivning till filen lyckades */
                if (Password.SaveToFile(Program.storedPasswordFile, newPass, key))
                {
                    MessageBox.Show("Lösenordet uppdaterades");
                }

                else
                {
                    MessageBox.Show("Sparning av nytt lösenord misslyckades!");
                }

                this.Close(); // Stäng "Ändra lösenord"-fönstret
            }
        }

        /* Event-metod för "Generera"-knappen */
        private void btnGenerateRandomPassword_Click(
            object sender, EventArgs e)
        {
            /* Skriv in ett slumpgenererat lösenord till textrutan */
            string gen = Password.GenerateRandomPassword();
            textBoxNewPassword.Text = gen;

            checkBoxShowPassword.Checked = true;
        }
    }
}
