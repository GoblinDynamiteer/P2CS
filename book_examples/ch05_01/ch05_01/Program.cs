using System;
using System.IO;

namespace ch05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            StreamWriter fileForWrite = new StreamWriter("WriteRead.txt");

            fileForWrite.WriteLine("\n\tTextText");
            fileForWrite.Close();

            StreamReader fileForRead = new StreamReader("WriteRead.txt");

            Console.WriteLine("From textfile: ");
            while (!fileForRead.EndOfStream)
            {
                word = fileForRead.ReadLine();
                Console.WriteLine(word);
            }

            fileForRead.Close();
            Console.ReadKey();
        
        }
    }
}
