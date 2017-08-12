﻿using System;
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
            member = new Member(membersDataSet, membersTableAdapter);
        }

        /* Hämta medlem-ID för den markerade medlemmen */
        public int GetSelectedMemberID()
        {
            int id = 0;

            /* Kör enbart en gång, då multi-select är satt 
             * till false för DataGridView-kontrollen */
            foreach (DataGridViewRow row in 
                membersDataGridView.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
            }

            return id;
        }

        /* Anropas när fönstret/from-kontrollen stängs */
        private void frmMain_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            UpdateDatabase();
            Program.QuitProgram();
        }

        /* Anropas när fönstret/from-kontrollen startas */
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

            UpdateMemberCountLabel();

            if (membersDataGridView.RowCount < 1)
            {
                btnRemoveMember.Enabled = false;
            }
            
        }

        /* Anropas när användaren markerar en (ny) medlem i medlemslistan  */
        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int memberId = GetSelectedMemberID();

            tigersTableAdapter.FillByOwnerID(
                    membersDataSet.Tigers,
                    memberId
                );

            lblName.Text = member.GetName(memberId);
        }

        /* Anropas när användaren trycker på knappen 'Radera medlem'  */
        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            
            int deleteID = GetSelectedMemberID();
            member.RemoveByID(deleteID);
            
            UpdateDatabase();
            UpdateMemberCountLabel();

            if (membersDataGridView.RowCount < 1)
            {
                btnRemoveMember.Enabled = false;
            }

        }

        /* Uppdaterar texten för antal medlemmar. */
        public void UpdateMemberCountLabel()
        {
            /* Antal medlemmar hämtas från DataGridView-kontrollen */
            lblNumberOfMembers.Text = string.Format(
                "Medlemmar: {0}", membersDataGridView.RowCount);
        }

        /* Anropas när användaren trycker på knappen 'Ny medlem'  */
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            /* Skapa och öppna ett nytt fönster för att lägga till
             * en ny medlem. */
            addMemberWindow = new frmAddMember(this);
            addMemberWindow.Show();
        }

        public void UpdateDatabase()
        {
            try
            {
                Validate();
                membersBindingSource.EndEdit();
                membersTableAdapter.Update(membersDataSet.Members);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
