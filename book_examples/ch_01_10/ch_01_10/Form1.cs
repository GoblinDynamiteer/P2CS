/* Programmering 2 med C#
 * Example 1.10
 * Page 47
 * 
 * Calendar
 * Input orderdate, output expected delivery date
 * if fri/sat/sun, add 3 days, else add 2
 * 
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Windows.Forms;

namespace ch_01_10
{
    public partial class DeliveryDate : Form
    {
        public DeliveryDate()
        {
            InitializeComponent();
        }

        /* Value changes in dateTimePicker */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime orderDate = dateTimePicker1.Value;

            if (orderDate.DayOfWeek == DayOfWeek.Friday ||
                orderDate.DayOfWeek == DayOfWeek.Saturday ||
                orderDate.DayOfWeek == DayOfWeek.Sunday)
            {
                outputLabel.Text = orderDate.AddDays(3).ToLongDateString();
            }

            else
            {
                outputLabel.Text = orderDate.AddDays(2).ToLongDateString();
            }
        }

        /* When program loads, set date to dateTimePicker */
        private void DeliveryDate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
