/* Programmering 2 med C#
 * Example 1.1
 * Page 10
 * 
 * Windows Forms with button and message box
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch01_1
{
    public partial class Form1 : Form // Form1 inherits Form
    {
        public Form1() // Consructor
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox text that shows every " +
                "time the button is clicked!", "MessageBox Title");
        }
    }
}
