using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmAddMember : Form
    {
        frmMain Main;

        public frmAddMember(frmMain mainForm)
        {
            InitializeComponent();
            this.Main = mainForm;

            dateTimePickerBirth.MaxDate = DateTime.Today;
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        public void AddMemberFromForm(object sender, EventArgs e)
        {
            /* Fixa röda labels för fel inmatning, tryparse för int etc */
        }
    }
}
