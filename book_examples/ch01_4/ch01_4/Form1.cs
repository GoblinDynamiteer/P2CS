using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch01_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            /* Set background color from scrollbar values */
            BackColor = Color.FromArgb(
                hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            /* Show scrollbar values in labels */
            label1.Text = Convert.ToString(hScrollBar1.Value);
            label2.Text = Convert.ToString(hScrollBar2.Value);
            label3.Text = Convert.ToString(hScrollBar3.Value);
        }
    }
}
