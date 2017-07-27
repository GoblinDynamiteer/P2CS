/* Programmering 2 med C#
 * Example 1.2
 * Page 16
 * 
 * TextBox, Password masking, labels
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMe_Click(object sender, EventArgs e)
        {
            /* Set label text to text from textbox */
            lbShowPasswd.Text = tbPasswd.Text;
        }
    }
}
