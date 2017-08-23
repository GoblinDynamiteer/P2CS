using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmAddTiger : Form
    {
        frmMain frmMain;
        int ownerId;

        /* Konstruktor */
        public frmAddTiger(frmMain frmMain, int ownerId)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.ownerId = ownerId;

            comboBoxTigerType.SelectedIndex = 0;
            errorIconName.Visible = false;

            /* Fönstertitel */
            this.Text = "Lägg till tiger till " +
                frmMain.member.GetName(ownerId);
        }

        /* Anropas när användaren trycker på knappen 'Avbryt' */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Ser till att endast ett tigerkön är valbart */
        private void radioButtonGenderSwap(object sender, EventArgs e)
        {
            if (sender == radioButtonFemale)
            {
                radioButtonMale.Checked = !radioButtonFemale.Checked;
            }

            else
            {
                radioButtonFemale.Checked = !radioButtonMale.Checked;
            }
        }

        /* Anropas när användaren trycker på knappen 'Lägg till' */
        private void btnAddTiger_Click(object sender, EventArgs e)
        {
            /* Visa felindikator vid namn-textrua om denna är tom */
            if (textBoxTigerName.Text == "")
            {
                errorIconName.Visible = true;
            }

            else
            {
                bool isMale = radioButtonMale.Checked ? true : false;

                frmMain.tiger.AddTiger(
                        textBoxTigerName.Text,
                        comboBoxTigerType.Text,
                        isMale,
                        ownerId
                    );

                frmMain.UpdateLabelsAndButtons();
                Close();
            }

        }
    }
}
