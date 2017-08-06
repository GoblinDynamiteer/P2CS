using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trf
{
    public partial class frmAddMember : Form
    {
        frmMain mainForm;

        public frmAddMember(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            dateTimePickerBirth.MaxDate = DateTime.Today;
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        public void AddMemberFromForm(object sender, EventArgs e)
        {
            /* Fixa röda labels för fel inmatning, tryparse för int etc */


            mainForm.CreateMember(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    dateTimePickerBirth.Value,
                    textBoxStreet.Text,
                    textBoxCity.Text,
                    int.Parse(textBoxZipCode.Text),
                    "Sweden"
                );

            mainForm.PopulateMemberList();
            Close();
        }
    }
}
