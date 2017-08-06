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
    public partial class Main : Form
    {

        List<Owner> memberList;
        formAddMember formAddMember;

        public Main()
        {
            InitializeComponent();
            memberList = new List<Owner>();
            CreateMembers();
            PopulateMemberList();
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
            formAddMember = new formAddMember(this);
            formAddMember.Show();
        }

        /* Uppdaterar listboxen med medlemmars namn */
        public void PopulateMemberList()
        {
            /* Rensar listboxen */
            listBoxMembers.Items.Clear();

            /* Om det inte finns några medlemmar */
            if (!memberList.Any())
            {
                listBoxMembers.Items.Add("Inga medlemmar");
                return; // Avslutar metoden
            }
                
            /* Skriver in för- och efternamn för varje medlem 
             * till listboxen */
            foreach (Owner owner in memberList)
            {
                listBoxMembers.Items.Add(owner.GetName());
            }
            
        }
    }
}
