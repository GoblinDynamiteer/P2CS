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
    public partial class formAddMember : Form
    {
        Main mainForm;

        public formAddMember(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        public void AddMemberFromForm(object sender, EventArgs e)
        {
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
