using System;
using System.IO;

namespace ch05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] password = new char[8];
            Random r = new Random();
            string word, file = "userPasswd.txt";
            Console.Write("Enter amount of logins/passwords: ");
            int number = Convert.ToInt32(Console.ReadLine());

            StreamWriter fileForWrite = new StreamWriter(file);

            for (int i = 1; i <= number; i++)
            {
                RandPassword.OnePassword(r, password);
                fileForWrite.WriteLine("\tuser" + i + "\t\t" + new String(password));
            }

            fileForWrite.Close();

            StreamReader fileForRead = new StreamReader(file);
            Console.WriteLine("Generated logins: ");

            while (!fileForRead.EndOfStream)
            {
                word = fileForRead.ReadLine();
                Console.WriteLine(word);
            }

            fileForRead.Close();
            Console.ReadKey();
        }

        class RandPassword
        {
            /* Generate random password */
            public static void OnePassword(Random r, char[] p)
            {
                for (int i = 0; i < 3; i++)
                {
                    p[i] = (char)r.Next(97, (122 + 1));
                }

                for (int i = 3; i < 5; i++)
                {
                    p[i] = (char)r.Next(48, (57 + 1));
                }

                for (int i = 5; i < 8; i++)
                {
                    p[i] = (char)r.Next(65, (90 + 1));
                }
            }
        }
    }

}
