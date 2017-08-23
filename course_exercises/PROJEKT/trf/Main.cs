using System;
using System.Data;
using System.Windows.Forms;

namespace trf
{
    public partial class frmMain : Form
    {
        /* Forms/fönster */
        frmAddMember addMemberWindow;
        frmAddTiger addTigerWindow;
        frmChangePassword changePasswordWindow;
        frmWebBrowser webBrowserWindow;
        AboutBox aboutWindow;

        public Member member; 
        public Tiger tiger;

        /* Konstruktor */
        public frmMain()
        {
            InitializeComponent();

            this.Text = Program.name; // Titel

            /* Skapa Member- och Tiger-objekt. Skicka med 
             * referenser till dataset och adapter för databasen */
            member = new Member(
                dataset, adapterMembers);

            tiger = new Tiger(
                dataset, adapterTigers);
        }

        /* Anropas när fönstret/from-kontrollen startas */
        private void frmMain_Load(object sender, EventArgs e)
        {
            /* Fyll dataset med adapters */
            try
            {
                adapterMembers.Fill(dataset.Members);
                tiger.FillByMemberID(GetSelectedMemberID());
            }

            catch // Databasfel
            {
                /* Meddelanderuta */
                MessageBox.Show("Se till att filen Members.mdf finns! " +
                    "Programmet kommer att avsluta.",    // Text
                        "Fel vid inläsning av databas!", // Titel
                        MessageBoxButtons.OK,            // Knappar
                        MessageBoxIcon.Exclamation,      // Ikon
                        MessageBoxDefaultButton.Button1  // Markerad knapp
                );

                Program.QuitProgram(); // Stäng av programmet
            }

            UpdateLabelsAndButtons();

        }

        /* Hämta medlem-ID för den markerade/aktuella 
         * medlemmen */
        public int GetSelectedMemberID()
        {
            string rowID = "";

            try
            {
                rowID = ((DataRowView)membersBindingSource.Current).
                    Row["Id"].ToString();
            }

            catch
            {
            }

            if (int.TryParse(rowID, out int memberID))
            {
                return memberID;
            }

            return 0; // Om parse av text misslyckas
        }

        /* Hämta tiger-ID för den markerade/aktuella
         * tigern */
        public int GetSelectedTigerID()
        {
            string rowID = "";

            try
            {
                rowID = ((DataRowView)tigersBindingSource.Current).
                    Row["Id"].ToString();
            }

            catch
            {
            }

            if (int.TryParse(rowID, out int tigerID))
            {
                return tigerID;
            }

            return 0; // Om parse av text misslyckas
        }

        /* Uppdaterar text på labels och knappar. */
        public void UpdateLabelsAndButtons()
        {
            /* Antal medlemmar som visas i medlemslista. 
             * Alla eller med filter applicerat */
            lblNumberOfMembers.Text = string.Format(
                "Medlemmar: {0} {1}", dataView.RowCount,
                    textBoxFilter.Text == "" ?
                        "" : " ( Filter ) "); // ( Filter) vid filtrerad lista

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

        /* Anropas när fönstret/form-kontrollen stängs */
        private void frmMain_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            UpdateDatabase();
            Program.QuitProgram();
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

        /* Skriver till databasen */
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

        /* Event-metoder för sökfilter */
        #region SearchFilterEventMethods

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
        #endregion

        /* Event-metoder för knappar */
        #region ButtonEventMethods

        /* Knapp "Ny medlem"  */
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            /* Skapa och öppna ett nytt fönster för att lägga till
             * en ny medlem. */
            addMemberWindow = new frmAddMember(this);
            addMemberWindow.Show();
        }

        /* Knapp "Radera medlem"  */
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

        /* Knapp "Lägg till tiger" */
        private void btnAddTiger_Click(object sender, EventArgs e)
        {
            addTigerWindow = new frmAddTiger(this, GetSelectedMemberID());
            addTigerWindow.Show();
        }

        /* Knapp "Ta bort tiger" */
        private void btnRemoveTiger_Click(object sender, EventArgs e)
        {
            int tigerId = GetSelectedTigerID();
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

        #endregion

        /* Event-metoder för menyn */
        #region MenuStripEventMethods

        /* "Fil->Exportera" */
        private void exporteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* "Spara fil"-fönster */
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.Title = "Exportera medlemslista till textfil";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "memberlist.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!member.Export(saveFileDialog.FileName))
                {
                    MessageBox.Show("Kunde inte exportera medlemmar!");
                }

                UpdateLabelsAndButtons();
            }

        }

        /* Meny "Fil->Avsluta" och Knapp "Avsluta" */
        private void quitProgram(object sender, EventArgs e)
        {
            UpdateDatabase();
            Program.QuitProgram();
        }

        /* "Verktyg->Ändra lösenord" */
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordWindow = new frmChangePassword();
            changePasswordWindow.Show();
        }

        /* "Hjälp->Info om tigrar" */
        private void infoOmTigrarToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            /* Visa dialogruta med knapparna Ja/Nej */
            DialogResult result = MessageBox.Show(
                "Vill du besöka Wikipedia-sidan om tigrar?",
                "Info om tigrar",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                // System.Diagnostics.Process.Start(
                //    webpageUrlWikiTigers);
                webBrowserWindow = new frmWebBrowser();
                webBrowserWindow.Show();
            }
        }

        /* "Hjälp->Om programmet" */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow = new AboutBox(); // About-ruta
            aboutWindow.Show();
        }

        #endregion

    }
}
