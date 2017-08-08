using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trf
{
    class Password
    {
        int encryptionKey;
        static int maxKey = 400, minKey = 100;

        public Password(int encryptionKey)
        {
            this.encryptionKey = encryptionKey;
        }

        /* Kryptera text med angiven krypteringsnyckel */
        public static string EncryptText(string text, int key)
        {
            char ch;
            string temp = "";

            for (int i = 0; i < text.Length; i++)
            {
                ch = Convert.ToChar(text.Substring(i, 1));
                ch = (char)(ch + key);
                temp += ch;
            }

            return temp;
        }

        /* Dekryptera text med angiven krypteringsnyckel */
        public static string DecryptText(string text, int key)
        {
            return EncryptText(text, -key);
        }

        /* Generera slumpad krypteringsnyckel */
        public static int GenerateRandomEncryptionKey()
        {
            Random r = new Random();
            return r.Next(minKey, maxKey);
        }
    }
}
