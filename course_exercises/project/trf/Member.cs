using System.IO;
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

        /* Ger en medlems fulla namn (förnamn + efternamn) */
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
                }

            }

            return -1; // Om medlems-ID inte hittades

        }

        public bool Export(string filename)
        {
            adapter.Fill(dataset.Members);
            int memberCount = dataset.Members.Rows.Count;

            string[] name = new string[memberCount];
            string[] surname = new string[memberCount];
            string[] city = new string[memberCount];
            string[] street = new string[memberCount];
            string[] zipcode = new string[memberCount];
            string[] country = new string[memberCount];

            for (int i = 0; i < memberCount; i++)
            {
                name[i] = dataset.Members.Rows[i]["FirstName"].ToString();
                surname[i] = dataset.Members.Rows[i]["LastName"].ToString();
                city[i] = dataset.Members.Rows[i]["City"].ToString();
                street[i] = dataset.Members.Rows[i]["Street"].ToString();
                zipcode[i] = dataset.Members.Rows[i]["ZipCode"].ToString();
                country[i] = dataset.Members.Rows[i]["Country"].ToString();
            }

            StreamWriter file = new StreamWriter(filename, false);

            for (int i = 0; i < memberCount; i++)
            {
                file.WriteLine(name[i] + " " + surname[i]);
                file.WriteLine(street[i]);
                file.WriteLine(zipcode[i] + " " + city[i]);
                file.WriteLine(country[i].ToUpper());
                file.WriteLine("-----------------------------------");
                
            }

            file.Close();
            return true;
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

        /* Söker i medlemmar, fyller dataset efter resultat */
        public void SearchAll(string text)
        {
            if (text == "") // Om söksträng är tom
            {
                adapter.Fill(dataset.Members);
            }

            else
            {
                int zipSearch = 0; // För sökning i postnummer, int
                int.TryParse(text, out zipSearch);
                adapter.FillBySearchAll(dataset.Members, text, zipSearch);
            }
        }

    }

}
