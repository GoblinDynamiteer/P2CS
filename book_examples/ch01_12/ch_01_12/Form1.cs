/* Programmering 2 med C#
 * Example 1.12
 * Page 53
 * 
 * Multiple Document Interface
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch_01_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Create child windows (forms) */
        private void child1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("First Image", "\\Welcome.jpg");
            child.MdiParent = this;
            child.Show();
        }

        private void child2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("Second Image", "\\Welcome.jpg");
            child.MdiParent = this;
            child.Show();
        }

        private void child3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("Third Image", "\\Welcome.jpg");
            child.MdiParent = this;
            child.Show();
        }


        /* Arrange MDU windows */
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
