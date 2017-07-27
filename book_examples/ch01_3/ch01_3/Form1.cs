/* Programmering 2 med C#
 * Example 1.3
 * Page 18
 * 
 * Radiobuttons, quit application
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch01_3
{
    public partial class Bartender : Form
    {
        public Bartender()
        {
            InitializeComponent();
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            string output = "";

            /* Check drink(s) to be served */
            if (chkVodka.Checked && !chkGin.Checked)
                output = "Vodka is served ";
            if (!chkVodka.Checked && chkGin.Checked)
                output = "Gin is served ";
            if (chkVodka.Checked && chkGin.Checked)
                output = "Gin and vodka is served ";

            /* Check glass */
            if (optShotGlass.Checked)
                output += "in shot glass(es).";
            if (optVineGlass.Checked)
                output += "in wine glass(es).";
            if (optCocktailGlass.Checked)
                output += "in cocktail glass(es).";

            /* MessageBox output */
            MessageBox.Show(output, "The bartenter says:");

        }

        /* For quit button */
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
