using trf.MembersDataSetTableAdapters;

namespace trf
{
    public class Tiger
    {
        MembersDataSet dataset;
        TigersTableAdapter adapter;

        /* Konstruktor */
        public Tiger(MembersDataSet dataset,
                     TigersTableAdapter adapter)
        {
            this.dataset = dataset;
            this.adapter = adapter;
        }

        /* Radera tigrar som tillhör medlem */
        public void RemoveByMemberID(int memberId)
        {
            adapter.DeleteByOwnerID(memberId);
            adapter.Fill(dataset.Tigers);
        }

        /* Uppdatera listan med tigrar som tillhör medlemmen
         * som är markerad i medlemslistan */
        public void FillByMemberID(int memberId)
        {
            adapter.ClearBeforeFill = true;
            adapter.FillByOwnerID(dataset.Tigers, memberId);
        }

        /* Radera tiger med ID */
        public void RemoveByTigerID(int tigerId)
        {
            adapter.DeleteByTigerID(tigerId);
        }

        /* Lägg till en tiger till medlem */
        public void AddTiger(
            string name, string type, bool isMale, int memberId)
        {
            adapter.AddTiger(
                name, type, memberId, isMale ? "Hane" : "Hona");

            FillByMemberID(memberId);
        }
    }
}
