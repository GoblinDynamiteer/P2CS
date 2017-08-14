using trf.MembersDataSetTableAdapters;

namespace trf
{
    public class Member
    {
        MembersDataSet dataset;
        MembersTableAdapter adapter;

        public Member(MembersDataSet dataset, 
                      MembersTableAdapter adapter)
        {
            this.dataset = dataset;
            this.adapter = adapter;
        }

        /* Radera medlem */
        public void RemoveByID(int memberId)
        {
            adapter.DeleteQuery(memberId);
            adapter.Fill(dataset.Members);
        }

        /* Ger en medlems fulla namn */
        public string GetName(int memberId)
        {
            int index = GetRowIndex(memberId);

            if (index >= 0)
            {
                string firstName = 
                    dataset.Members.Rows[index]["FirstName"].ToString();
                string lastName = 
                    dataset.Members.Rows[index]["LastName"].ToString();
                return firstName + " " + lastName;
            }

            return "";
            
        }

        /* Hittar index-värde för rad i membersDataSet som matchar 
         * med sökt medlems-ID*/
        int GetRowIndex(int memberId)
        {
            for (int i = 0; i < dataset.Members.Rows.Count; i++)
            {
                try
                {
                    int id = int.Parse(
                            dataset.Members.Rows[i]["Id"].ToString()
                        );

                    if (id == memberId)
                    {
                        return i; // Avslutar metoden
                    }
                }

                catch
                {
                    //BYGG
                }

            }

            return -1; // Om medlems-ID inte hittades

        }

        /* Lägger till medlem */
        public void Add(string firstName, string secondName, string street, 
                        string city, string country, int zipCode)
        {
            adapter.InsertQuery(
                    firstName, secondName, street, 
                    zipCode, country, city
                );

            adapter.Fill(dataset.Members);
        }

        public void SearchAll(string text)
        {
            if (text == "")
            {
                adapter.Fill(dataset.Members);
            }

            else
            {
                adapter.FillBySearchAll(dataset.Members, text);
            }
        }

    }

}
