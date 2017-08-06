using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnPasswordOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
