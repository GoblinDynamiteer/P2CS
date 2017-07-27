/* Programmering 2 med C#
 * Example 1.4
 * Page 22
 * 
 * Scroll bars, background color
 * 
 * Extra:
 *  Made background change instantly when scrolling.
 *  Changed "show color" button to "reset"
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

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

        private void UpdateColor()
        {
            /* Set background color from scrollbar values */
            BackColor = Color.FromArgb(
                hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        /* Reset */
        private void btnShow_Click(object sender, EventArgs e)
        {
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;

            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";

            BackColor = Color.Snow;
        }

        /* Events for scrolling bars */
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            label1.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar2_Scroll_1(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            label2.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            label3.Text = Convert.ToString(hScrollBar3.Value);
        }
    }
}
