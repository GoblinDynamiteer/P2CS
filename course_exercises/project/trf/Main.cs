using System;
using System.Windows.Forms;

namespace trf
{
    public partial class frmMain : Form
    {
        /* Forms/fönster */
        frmAddMember addMemberWindow;
        frmAddTiger addTigerWindow;
        frmChangePassword changePasswordWindow;

        /* Objekt */
        public Member member; 
        public Tiger tiger;

        string webpageUrlWikiTigers = 
            "http://sv.wikipedia.org/wiki/Tiger";

        /* Konstruktor */
        public frmMain()
        {
            InitializeComponent();

            /* Fönstrets titel */
            this.Text = Program.name;

            member = new Member(
                dataset, adapterMembers);
            tiger = new Tiger(dataset, adapterTigers);
        }

        /* Hämta medlem-ID för den markerade medlemmen */
        public int GetSelectedMemberID()
        {
            if (int.TryParse(textBoxMemberId.Text, out int memberID))
            {
                return memberID;
            }

            return 0;
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
            textBoxMemberId.Visible = false;
            textBoxTigerID.Visible = false;

            try
            {
                adapterMembers.Fill(dataset.Members);
                tiger.FillByMemberID(GetSelectedMemberID());
            }

            catch
            {
                MessageBox.Show("Se till att filen Members.mdf finns! " +
                    "Programmet kommer att avsluta.",
                        "Fel vid inläsning av databas!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1
                );

                Program.QuitProgram();
            }

            finally
            {
                UpdateLabelsAndButtons();
            }

        }

        /* Anropas när användaren markerar en (ny) medlem i 
         * medlemslistan  */
        private void dataView_SelectionChanged(
            object sender, EventArgs e)
        {
            int memberId = GetSelectedMemberID();
            tiger.FillByMemberID(memberId);

            UpdateLabelsAndButtons();
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
                tiger.RemoveByMemberID(deleteID);
                member.RemoveByID(deleteID);

                UpdateDatabase();
                UpdateLabelsAndButtons();
            }
        }

        /* Uppdaterar text på labels och knappar. */
        public void UpdateLabelsAndButtons()
        {
            /* Antal medlemmar som visas i medlemslista. 
             * Alla eller med filter applicerat */
            lblNumberOfMembers.Text = string.Format(
                "Medlemmar: {0} {1}", dataView.RowCount, 
                    textBoxFilter.Text == "" ? 
                        "" : " ( Filter ) ");

            /* Antal ägda tigrar */
            lblTigersOwned.Text = string.Format(
                "Ägda tigrar: {0}", tigersListBox.Items.Count);

            /* Sätter land i medlemmens adress till VERSAL */
            lblCountry.Text = lblCountry.Text.ToUpper();

            lblName.Text = member.GetName(GetSelectedMemberID());

            /* Styr om det går att klicka på diverse knappar */
            btnRemoveMember.Enabled = dataView.RowCount < 1 ? false : true;
            btnAddTiger.Enabled = dataView.RowCount < 1 ? false : true;
            btnRemoveTiger.Enabled = 
                (dataView.RowCount < 1 || tigersListBox.Items.Count < 1) ? 
                false : true;

        }

        /* Anropas när användaren trycker på knappen 'Ny medlem'  */
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            /* Skapa och öppna ett nytt fönster för att lägga till
             * en ny medlem. */
            addMemberWindow = new frmAddMember(this);
            addMemberWindow.Show();
        }

        /* Skriver till den faktiska databasen ? */
        public void UpdateDatabase()
        {
            try
            {
                Validate();
                membersBindingSource.EndEdit();
                adapterMembers.Update(dataset.Members);
            }
            catch
            {
                MessageBox.Show("Databasuppdatering misslyckades");
            }
        }

        /* Anropas när avändaren väljer "info om tigrar" i 
         * hjälp-menyn */
        private void infoOmTigrarToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            /* Visa dialogruta med knapparna Ja/Nej */
            DialogResult result = MessageBox.Show(
                "Vill du besöka Wikipedia-sidan om tigrar?",
                "Info om trigrar",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(
                    webpageUrlWikiTigers);
            }
        }

        /* Anropas när användaren trycker på knappen "Ta bort tiger" */
        private void btnRemoveTiger_Click(object sender, EventArgs e)
        {
            int tigerId = int.Parse(textBoxTigerID.Text);
            int memberId = GetSelectedMemberID();

            /* Visa dialogruta med knapparna Ja/Nej */
            DialogResult result = MessageBox.Show(
                "Är du säker på att du vill ta bort " 
                    + tigersListBox.Text + " ?",
                "Radera tiger",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                tiger.RemoveByTigerID(tigerId);
                tiger.FillByMemberID(memberId);
                UpdateLabelsAndButtons();
            }
            
        }

        /* Anropas när användaren trycker på knappen "Lägg till tiger" */
        private void btnAddTiger_Click(object sender, EventArgs e)
        {
            addTigerWindow = new frmAddTiger(this, GetSelectedMemberID());
            addTigerWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            Program.QuitProgram();
        }

        /* Anropas när användaren trycker på menyn "Verktyg->Ändra lösenord" */
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordWindow = new frmChangePassword();
            changePasswordWindow.Show();
        }

        /* Anropas när text ändras i sökfilter-rutan */
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            member.SearchAll(textBoxFilter.Text);
            UpdateLabelsAndButtons();
        }

        /* Anropas när användaren dubbelklickar på sökfilter-rutan */
        private void textBoxFilter_DoubleClick(object sender, EventArgs e)
        {
            textBoxFilter.Text = ""; // Rensa filter
        }
    }
}
