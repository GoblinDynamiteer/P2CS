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

        public void RemoveByID(int memberId)
        {
            int index = GetRowIndex(memberId);

            if (index >= 0)
            {
                membersDataSet.Members.Rows[index].Delete();
                //UpdateDabatase();
            }

        }

        public string GetName(int memberId)
        {
            int index = GetRowIndex(memberId);

            if (index >= 0)
            {
                string firstName = membersDataSet.Members.Rows[index]["FirstName"].ToString();
                string lastName = membersDataSet.Members.Rows[index]["LastName"].ToString();
                return firstName + " " + lastName;
            }

            return "";
            
        }

        int GetRowIndex(int memberId)
        {
            for (int i = 0; i < membersDataSet.Members.Rows.Count; i++)
            {
                try
                {
                    int id = int.Parse(membersDataSet.Members.Rows[i]["Id"].ToString());

                    if (id == memberId)
                    {
                        return i;
                    }
                }

                catch
                {
                    //BYGG
                }

            }
            return -1;

        }

        public void Add(string firstName, string secondName, string street, 
                 string city, string country, int zipCode)
        {
            membersTableAdapter.Insert(
                    firstName, secondName, street, 
                    zipCode, country, city
                );

            UpdateDabatase();
        }

        void UpdateDabatase()
        {
            membersDataSet.AcceptChanges();
            membersTableAdapter.Fill(membersDataSet.Members);
        }

    }

}
