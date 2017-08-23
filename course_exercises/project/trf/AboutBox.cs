using System;
using System.Windows.Forms;

namespace trf
{
    partial class AboutBox : Form
    {
        /* Konstruktor */
        public AboutBox()
        {
            InitializeComponent();

            /* Sätt text för "Om-fönstret" */
            this.Text = "Om programmet"; // Titel
            this.labelProductName.Text = "TRF Tigerälskarnas riksförbund.";
            this.labelVersion.Text = "1.0";
            this.labelCopyright.Text = "©2017";
            this.labelCompanyName.Text = "Johan Kämpe";

            /* '\r\n' ger radbrytning */
            this.textBoxDescription.Text = "Projekt för distanskursen Programmering 2 C#\r\n" +
                                            "NTI-Skolan\r\n\r\n" +
                                            "Av Johan kämpe\r\n" +
                                            "https://www.linkedin.com/in/johankampe\r\n" +
                                            "https://github.com/GoblinDynamiteer\r\n";
        }

        /* Event-metod för OK-knappen */
        private void okButton_Click(object sender, EventArgs e)
        {
            Close(); // Stäng "Om-fönstret"
        }
    }
}
