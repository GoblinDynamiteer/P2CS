using trf.MembersDataSetTableAdapters;

namespace trf
{
    class Tiger
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

        public void FillByMemberID(int memberId)
        {
            adapter.FillByOwnerID(dataset.Tigers, memberId);
        }
    }
}
