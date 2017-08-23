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
                /* Tar tecken i text och sätter till char-variabel */
                ch = Convert.ToChar(text.Substring(i, 1));

                /* "Ökar" teckenvärdet med värdet i krypteringsnyckeln */
                ch = (char)(ch + key);

                temp += ch;
            }

            return temp;
        }

        /* Dekryptera text med angiven krypteringsnyckel */
        public static string DecryptText(string text, int key)
        {
            /* Med negativt värde på krypteringsnyckeln så subtraheras
             * teckenvärdena i texten med värdet i krypteringsnyckeln*/
            return EncryptText(text, -key);
        }

        /* Generera slumpad krypteringsnyckel */
        public static int GenerateRandomKey()
        {
            Random r = new Random();
            return r.Next(100, 400);
        }

        /* Generera ett slumpmässigt lösenord
         * Exempel:
         *   tzql0995PXOJ
         *   tpyq8643RFBZ
         *   fhhk3879SHTA   */
        public static string GenerateRandomPassword()
        {
            char[] p = new char[12]; // 12 tecken
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                /* Acii 97-122: a-z */
                p[i]    = (char)r.Next(97, (122 + 1));

                /* Acii 48-57: 0-9 */
                p[i+4]  = (char)r.Next(48, (57 + 1));

                /* Acii 65-90: A-Z */
                p[i+8]  = (char)r.Next(65, (90 + 1));
            }

            return new string(p);
        }

        /* Sparar lösenord (redan krypterat) och nyckel till fil */
        public static bool SaveToFile(string fileName, string text, int key)
        {
            bool success = true;

            try
            {
                StreamWriter file = new StreamWriter(fileName, false);
                file.WriteLine(text); // Lösenordet på rad 1
                file.WriteLine(key);  // Krypteringsnyckeln på rad 2
                file.Close();
            }

            catch
            {
                success = false; // Misslyckad skrivning
            }

            return success;
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
                text = file.ReadLine(); // Lösenordet på rad 1
                key = int.Parse(file.ReadLine()); // Krypteringsnyckeln på rad 2
                file.Close();
            }

            catch
            {
                success = false; // Misslyckad inläsning
            }

            return success; 
        }

    }
}
