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
        public static int GenerateRandomKey()
        {
            Random r = new Random();
            return r.Next(100, 400);
        }

        /* Generera ett slumpmässigt lösenord */
        public static string GenerateRandomPassword()
        {
            char[] p = new char[12];
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                p[i]    = (char)r.Next(97, (122 + 1));
                p[i+4]  = (char)r.Next(48, (57 + 1));
                p[i+8]  = (char)r.Next(65, (90 + 1));
            }

            return new string(p);
        }

        /* Laddar krypterat lösenord från angiven textfil, ger text och nyckel
         * som "out"-parametrar. Ger sanningsvärde beroende på om filen gick
         * att läsa in. */
        public static bool LoadFromFile(
            string fileName, out int key, out string text)
        {
            text = "";
            key = 0;
            bool success = true;

            try
            {
                StreamReader file = new StreamReader(fileName);
                text = file.ReadLine();
                key = int.Parse(file.ReadLine());
                file.Close();
            }

            catch
            {
                success = false; // Misslyckad inläsning
            }

            return success; 
        }

        /* Sparar lösenord (redan krypterat) och nyckel till fil */
        public static bool SaveToFile(string fileName, string text, int key)
        {
            bool success = true;

            try
            {
                StreamWriter file = new StreamWriter(fileName, false);
                file.WriteLine(text);
                file.WriteLine(key);
                file.Close();
            }

            catch
            {
                success = false;
            }

            return success;
        }
    }
}
