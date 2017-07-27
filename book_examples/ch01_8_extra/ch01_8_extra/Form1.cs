using System;
using System.Windows.Forms;

namespace ch01_8_extra
{
    public partial class Form1 : Form
    {
        AboutBox myAboutBox = new AboutBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAboutBox.ShowDialog();
        }
    }
}
