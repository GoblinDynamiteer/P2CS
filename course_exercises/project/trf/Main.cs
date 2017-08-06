using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trf
{
    public partial class frmMain : Form
    {

        List<Owner> memberList;
        frmAddMember addMemberWindow;

        public frmMain()
        {
            InitializeComponent();
            this.Text = Program.name;

            memberList = new List<Owner>();

            CreateMembers();
            PopulateMemberListBox();
            btnRemoveMember.Enabled = false;
        }

        public void CreateMembers()
        {
            DateTime birth = new DateTime(1983, 6, 19);

            CreateMember("John", "Karlsson", birth,
                    "Storgatan 12B", "Motala", 59138, "Sweden");


            CreateMember("Kalle", "Svensson", birth,
                    "Litengatan 33", "Vadstena", 58131, "Sweden");


            CreateMember("Anna", "Larsson", birth,
                    "Vändgatan 12", "Stockholm", 12342, "Sweden");
        }

        public void CreateMember(string firstName, string lastName, 
            DateTime birth, string street, string town, int zip, string country)
        {
            memberList.Add(
                    new Owner(firstName, lastName, birth, street, town, zip, country)
                );
        }

        void AddMemberFormShow(object sender, EventArgs e)
        {
            addMemberWindow = new frmAddMember(this);
            addMemberWindow.Show();
        }

        /* Uppdaterar listboxen med medlemmars namn */
        public void PopulateMemberListBox()
        {
            /* Rensar listboxen */
            listBoxMembers.Items.Clear();

            /* Om det inte finns några medlemmar */
            if (!memberList.Any())
            {
                listBoxMembers.Items.Add("Inga medlemmar");

                btnRemoveMember.Enabled = false;
                return; // Avslutar metoden
            }
                
            /* Skriver in för- och efternamn för varje medlem 
             * till listboxen */
            foreach (Owner owner in memberList)
            {
                listBoxMembers.Items.Add(owner.GetName());
            }
            
        }

        /* Anropas när en medlem markeras i medlemslistan */
        private void listBoxMembersSelect(object sender, EventArgs e)
        {
            if (memberList.Any() && listBoxMembers.SelectedIndex <= memberList.Count - 1)
            {
                btnRemoveMember.Enabled = true;
                int index = listBoxMembers.SelectedIndex;

                /* Bygg metod för att visa all data? */
                lblName.Text = memberList[index].GetName();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.QuitProgram();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            int index = listBoxMembers.SelectedIndex;
            DialogResult result = MessageBox.Show(
                "Vill du verkligen radera medlemmen " + memberList[index].GetName() + "?", 
                "Radera Medlem", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                memberList.RemoveAt(index);
                PopulateMemberListBox();
            }

        }
    }
}
