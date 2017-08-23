using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmAddMember : Form
    {
        frmMain frmMain;

        /* Referens till huvudfönstret/form skickas som referens för att 
         * kunna anropas dess member-objekt */
        public frmAddMember(frmMain frmMain)
        {
            InitializeComponent();

            this.frmMain = frmMain;

            errorIconCity.Visible = false;
            errorIconFirstName.Visible = false;
            errorIconLastName.Visible = false;
            errorIconZipCode.Visible = false;
            errorIconStreet.Visible = false;
            errorIconCountry.Visible = false;
        }

        /* Anropas när användaren trycker på knappen 'Avbryt' */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); // Stäng fönstret
        }

        /* Anropas när användaren trycker på knappen 'Lägg till' */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool correctInput = true; // felflagga

            /* Hämtar text från textrutor */
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string city = textBoxCity.Text;
            string country = textBoxCountry.Text;
            string street = textBoxStreet.Text;

            /* Visar felindikator vid tomma textrutor */
            errorIconFirstName.Visible = firstName == "" ? true : false;
            errorIconLastName.Visible = lastName == "" ? true : false;
            errorIconCity.Visible = city == "" ? true : false;
            errorIconCountry.Visible = country == "" ? true : false;
            errorIconStreet.Visible = street == "" ? true : false;
            errorIconZipCode.Visible = false;

            /* Sätt felflagga om någon textruta är tom */
            if (firstName == "" || lastName == "" || city == "" || 
                street == "" || country == "")
            {
                correctInput = false;
            }

            /* Testa att parsa texten i postnummer-rutan till int,
             * visa felindikator och sätt felflagga vid misslyckande */
            if (!int.TryParse(textBoxZipCode.Text, out int zipCode))
            {
                errorIconZipCode.Visible = true;
                correctInput = false;
            }

            /* Om all inmatning ör korrekt */
            if (correctInput)
            {
                frmMain.member.Add(
                        firstName, 
                        lastName, 
                        street, 
                        city, 
                        country, 
                        zipCode
                    );

                frmMain.UpdateLabelsAndButtons();
                Close(); // Stäng fönstret
            }
            
        }
    }
}
