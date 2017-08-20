using System;
using System.Windows.Forms;

namespace trf
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = "Om programmet";
            this.labelProductName.Text = "TRF Tigerälskarnas riksförbund.";
            this.labelVersion.Text = "1.0";
            this.labelCopyright.Text = "©2017";
            this.labelCompanyName.Text = "Johan Kämpe";
            this.textBoxDescription.Text = "Projekt för distanskursen Programmering 2 C#\r\n" +
                                            "NTI-Skolan\r\n\r\n" +
                                            "Av Johan kämpe\r\n" +
                                            "https://www.linkedin.com/in/johankampe\r\n" +
                                            "https://github.com/GoblinDynamiteer\r\n";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
