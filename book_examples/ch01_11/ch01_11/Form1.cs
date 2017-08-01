/* Programmering 2 med C#
 * Example 1.11
 * Page 49
 * 
 * Use menus to change text font/style/color
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch01_11
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Show a messageBox with set buttons and icon */
            MessageBox.Show(
                    "This program demonstrates menus!",
                    "About",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

        /* Exit program */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Clear color selections from menu */
        private void clearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        /* Clear font selections from menu */
        private void clearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        /* Color methods */
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }


        /* Font Methods */
        private void setFontTimesNewRoman(object sender, EventArgs e)
        {
            clearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);
        }

        private void setFontCourier(object sender, EventArgs e)
        {
            clearFont();
            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);
        }

        private void setFontComicSans(object sender, EventArgs e)
        {
            clearFont();
            comicSansToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans", 14, displayLabel.Font.Style);
        }

        private void setFontStyleBold(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            displayLabel.Font = new Font(
                    displayLabel.Font, // Use current font
                    displayLabel.Font.Style ^ FontStyle.Bold // Append style
                );
        }

        private void setFontStyleItalic(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            displayLabel.Font = new Font(
                    displayLabel.Font, // Use current font
                    displayLabel.Font.Style ^ FontStyle.Italic // Append style
                );
        }
    }
}
