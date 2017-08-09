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
        public Member member;

        public frmMain()
        {
            InitializeComponent();
            this.Text = Program.name;
            btnRemoveMember.Enabled = true;
            member = new Member(membersDataSet, membersTableAdapter);
            UpdateMemberCountLabel();
        }

        public int GetSelectedMemberID()
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
                membersTableAdapter.Fill(membersDataSet.Members);
                tigersTableAdapter.Fill(membersDataSet.Tigers);
            }

            catch
            {
            }

        }

        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int memberId = GetSelectedMemberID();

            tigersTableAdapter.FillByOwnerID(
                    membersDataSet.Tigers,
                    memberId
                );

            lblName.Text = member.GetName(memberId);
        }


        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            int deleteID = GetSelectedMemberID();
            member.RemoveByID(deleteID);
            UpdateMemberCountLabel();
        }

        private void UpdateMemberCountLabel()
        {
            lblNumberOfMembers.Text = string.Format("Medlemmar: {0}", member.Count());
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            addMemberWindow = new frmAddMember(this);
            addMemberWindow.Show();
            
        }
    }
}
