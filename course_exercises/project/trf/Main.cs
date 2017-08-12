using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmMain : Form
    {

        frmAddMember addMemberWindow;
        public Member member;

        string webpageUrlWikiTigers = "http://sv.wikipedia.org/wiki/Tiger";
        string toolTipTigerInfo = "Markera en tiger i listan för att se info.";

        public frmMain()
        {
            InitializeComponent();
            this.Text = Program.name; // Fönstrets titel
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
            SetTooltips();

            try
            {
                membersTableAdapter.Fill(membersDataSet.Members);
                UpdateTigerListBox();
                
            }

            catch
            {
                MessageBox.Show("Fel vid inläsning av databas.",
                    "Fel!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                );
            }

            finally
            {
                UpdateMemberCountLabel();
                

                if (membersDataGridView.RowCount < 1)
                {
                    btnRemoveMember.Enabled = false;
                }
            }

        }

        /* Anropas när användaren markerar en (ny) medlem i medlemslistan  */
        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTigerListBox();

            lblName.Text = member.GetName(GetSelectedMemberID());
        }

        /* Anropas när användaren trycker på knappen 'Radera medlem'  */
        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            int deleteID = GetSelectedMemberID();

            /* Visa dialogruta med knapparna Ja/Nej */
            DialogResult result = MessageBox.Show(
                "Är du säker på att du vill radera " 
                + member.GetName(deleteID) + "?",
                "Radering av medlem",
                MessageBoxButtons.YesNo
            );

            /* Om användaren trycker på Ja */
            if (result == DialogResult.Yes)
            {
                member.RemoveByID(deleteID);

                UpdateDatabase();
                UpdateMemberCountLabel();

                if (membersDataGridView.RowCount < 1)
                {
                    btnRemoveMember.Enabled = false;
                }
            }
        }

        /* Uppdatera listan med tigrar som tillhör medlemmen
         * som är markerad i medlemslistan */
        private void UpdateTigerListBox()
        {
            int memberId = GetSelectedMemberID();

            tigersTableAdapter.FillByOwnerID(
                    membersDataSet.Tigers,
                    memberId
                );
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

        private void infoOmTigrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Visa dialogruta med knapparna Ja/Nej */
            DialogResult result = MessageBox.Show(
                "Vill du besöka Wikipedia-sidan om tigrar?",
                "Info om trigrar",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(webpageUrlWikiTigers);
            }
        }

        void SetTooltips()
        {
            ToolTip tigersTooltip = new ToolTip();

            tigersTooltip.SetToolTip(
                tigersListBox, toolTipTigerInfo);
            tigersTooltip.SetToolTip(
                groupBoxTigerInfo, toolTipTigerInfo);
        }

    }
}
