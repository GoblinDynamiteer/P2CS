using System;
using System.IO;

namespace trf
{
    class Password
    {
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
        public static int GenerateRandomKey(
            int minKey, int maxKey, Random r)
        {
            return r.Next(minKey, maxKey);
        }

        public static bool LoadFromFile(string fileName, out int key, out string text)
        {
            text = "";
            key = 0;

            try
            {
                StreamReader file = new StreamReader(fileName);
                text = file.ReadLine();
                key = int.Parse(file.ReadLine());
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static void SaveToFile(string fileName, string text, int key)
        {
            StreamWriter file = new StreamWriter(fileName);
            file.WriteLine(text);
            file.WriteLine(key);
            file.Close();
        }
    }
}
