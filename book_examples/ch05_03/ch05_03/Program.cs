using System;
using System.IO;

namespace ch05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-encrypted file: ");
            string fileText = ReadShowFile.ReadShow("OriginalText.txt");
            Console.WriteLine();

            Random r = new Random();

            /* Randomize encryption key */
            int key = RandomNo.Rand(r, 50, 250);

            /* Encrypt text in file, and show content */
            fileText = EncryptText.Encrypt(fileText, key);
            WriteFile.Write(fileText, "Encrypted.txt");
            Console.WriteLine("Encrypted file: ");
            fileText = ReadShowFile.ReadShow("Encrypted.txt");

            /* Decrypt text in file, and show content */
            fileText = EncryptText.Encrypt(fileText, -key);
            WriteFile.Write(fileText, "Recovered.txt");
            Console.WriteLine("Recovered: ");
            fileText = ReadShowFile.ReadShow("Recovered.txt");

            /* Display encryption key used */
            Console.WriteLine("Encryption key:\t" + key);

            Console.ReadKey();
        }
    }

    /* Encrypt passed string, return encrypted string */
    class EncryptText
    {
        public static string Encrypt(string t, int k)
        {
            char ch;
            string temp = "";

            for (int i = 0; i < t.Length; i++)
            {
                ch = Convert.ToChar(t.Substring(i, 1));
                ch = (char)(ch + k);
                temp += ch;
            }

            return temp;
        }
    }

    /* Write string to file */
    class WriteFile
    {
        public static void Write(string t, string fileName)
        {
            StreamWriter fileForWrite = new StreamWriter(fileName);
            fileForWrite.WriteLine(t);
            fileForWrite.Close();
        }
    }

    /* Open file, read content */
    class ReadShowFile
    {
        public static string ReadShow(string filename)
        {
            string word, temp = "";
            StreamReader fileForRead = new StreamReader(filename);
            while (!fileForRead.EndOfStream)
            {
                word = fileForRead.ReadToEnd();
                Console.WriteLine(word);
                temp += word;
            }

            fileForRead.Close();
            return temp;
        }
    }

    /* Generate a random number */
    class RandomNo
    {
        public static int Rand(Random r, int a, int b)
        {
            if (a < b)
            {
                return a + r.Next() % (b - a + 1);
            }

            return b + r.Next() % (a - b + 1);
        }
    }
}
