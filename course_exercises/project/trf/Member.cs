using trf.MembersDataSetTableAdapters;

namespace trf
{
    public class Member
    {
        MembersDataSet membersDataSet;
        MembersTableAdapter membersTableAdapter;

        public Member(MembersDataSet membersDataSet, 
                      MembersTableAdapter membersTableAdapter)
        {
            this.membersDataSet = membersDataSet;
            this.membersTableAdapter = membersTableAdapter;
        }

        /* Radera medlem */
        public void RemoveByID(int memberId)
        {
            membersTableAdapter.DeleteQuery(memberId);
            membersTableAdapter.Fill(membersDataSet.Members);
        }

        /* Ger en medlems fulla namn */
        public string GetName(int memberId)
        {
            int index = GetRowIndex(memberId);

            if (index >= 0)
            {
                string firstName = 
                    membersDataSet.Members.Rows[index]["FirstName"].ToString();
                string lastName = 
                    membersDataSet.Members.Rows[index]["LastName"].ToString();
                return firstName + " " + lastName;
            }

            return "";
            
        }

        /* Hittar index-värde för rad i membersDataSet som matchar 
         * med sökt medlems-ID*/
        int GetRowIndex(int memberId)
        {
            for (int i = 0; i < membersDataSet.Members.Rows.Count; i++)
            {
                try
                {
                    int id = int.Parse(
                            membersDataSet.Members.Rows[i]["Id"].ToString()
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
            membersTableAdapter.InsertQuery(
                    firstName, secondName, street, 
                    zipCode, country, city
                );

            membersTableAdapter.Fill(membersDataSet.Members);
        }

    }

}
