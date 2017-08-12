using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmAddMember : Form
    {

        frmMain frmMain;

        public frmAddMember(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string city = textBoxCity.Text;
            string country = "FASD";
            string street = textBoxStreet.Text;
            int zipCode = int.Parse(textBoxZipCode.Text);

            frmMain.member.Add(firstName, lastName, street, city, country, zipCode);
            frmMain.UpdateMemberCountLabel();
        }
    }
}
