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
        }

        /* Anropas när användaren trycker på knappen 'Avbryt' */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Anropas när användaren trycker på knappen 'Lägg till' */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool correctInput = true;

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string city = textBoxCity.Text;
            string country = textBoxCountry.Text;
            string street = textBoxStreet.Text;

            errorIconFirstName.Visible = firstName == "" ? true : false;
            errorIconLastName.Visible = lastName == "" ? true : false;
            errorIconCity.Visible = city == "" ? true : false;
            errorIconCountry.Visible = country == "" ? true : false;
            errorIconStreet.Visible = street == "" ? true : false;
            errorIconZipCode.Visible = false;

            if (firstName == "" || lastName == "" || city == "" || 
                street == "" || country == "")
            {
                correctInput = false;
            }

            if (!int.TryParse(textBoxZipCode.Text, out int zipCode))
            {
                errorIconZipCode.Visible = true;
                correctInput = false;
            }

            if (correctInput)
            {
                frmMain.member.Add(firstName, lastName, street, city, country, zipCode);
                frmMain.UpdateMemberCountLabel();
                Close();
            }
            
            
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            errorIconCity.Visible = false;
            errorIconFirstName.Visible = false;
            errorIconLastName.Visible = false;
            errorIconZipCode.Visible = false;
            errorIconStreet.Visible = false;
            errorIconCountry.Visible = false;
        }
    }
}
