/* Programmering 2 med C#
 * Example 1.9
 * Page 45
 * 
 * ListBoxes
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch01_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Move selected item from listBox1 to listBox2 */
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);
        }

        /* Move selected item from listBox2 to listBox1 */
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.Text);
        }
    }
}
