using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch06_07
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }

        private void addressesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressBookDataSet);

        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.Addresses' table. You can move, or remove it, as needed.
            this.addressesTableAdapter.Fill(this.addressBookDataSet.Addresses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addressesTableAdapter.FillByLastName(
                addressBookDataSet.Addresses, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addressesTableAdapter.Fill(addressBookDataSet.Addresses);
            textBox1.Text = "";
        }
    }
}
