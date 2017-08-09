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

        frmAddMember addMemberWindow;

        public frmMain()
        {
            InitializeComponent();
            this.Text = Program.name;
            btnRemoveMember.Enabled = true;
        }

        int GetSelectedMemberID()
        {
            int id = 0;

            foreach (DataGridViewRow row in membersDataGridView.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
            }

            return id;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.QuitProgram();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                membersTableAdapter.Insert("Kalle", "Anka", "Bogatan 12", 12345, "Sverige", "Solstad");
                membersTableAdapter.Fill(membersDataSet.Members);
                tigersTableAdapter.Fill(membersDataSet.Tigers);
            }

            catch
            {
            }

        }

        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            tigersTableAdapter.FillByOwnerID(membersDataSet.Tigers, GetSelectedMemberID());
        }


        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            int deleteID = GetSelectedMemberID();

            for (int i = 0; i < membersDataSet.Members.Rows.Count; i++)
            {
                int id = int.Parse(membersDataSet.Members.Rows[i]["Id"].ToString());

                if (id == deleteID)
                {
                    membersDataSet.Members.Rows[i].Delete();
                    membersTableAdapter.Update(membersDataSet);
                    //membersTableAdapter.Fill(membersDataSet.Members);
                    break;
                }
            }

        }
    }
}
