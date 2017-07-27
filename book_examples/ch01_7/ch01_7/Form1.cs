/* Programmering 2 med C#
 * Example 1.7
 * Page 31
 * 
 * Interest calculator
 * 
 * Formula: 
 *  balance = capital * (1 + interestRate/100) ^ years
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch01_7
{
    public partial class TaxCalc : Form
    {
        public TaxCalc()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double balance;

            /* Get data from user input */
            double capital      = Convert.ToDouble(tbCapital.Text);
            double interestRate = Convert.ToDouble(tbInterestRate.Text);
            int years           = Convert.ToInt32(numUpDownYear.Value);

            /* Text to show in multiline text box */
            string output = "Year\t\tBalance\r\n\r\n";

            for (int i = 1; i <= years; i++)
            {
                balance = capital * Math.Pow((1 + interestRate / 100), i);

                /* 0:C currency formatting */
                output += i + "\t\t" + string.Format("{0:C}", balance) + "\r\n";
            }

            tbDisplay.Text = output;
        }
    }
}
