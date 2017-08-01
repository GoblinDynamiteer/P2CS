/* Programmering 2 med C#
 * Exercise 4.3
 * Page 174
 * 
 * Modify program ArrayOfRef (page 94)
 * 
 * Declare Class Fish' data members as private,
 * and methods as having no access modifiers.
 * 
 * Add a constructor and a toString() method that
 * overshadows the Object-class one.
 * 
 * The modified program shall function as the original.
 * 
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish[] f = new Fish[5];
            bool autofish = false; // Got tired of manually entering fish!

            if (!autofish)
            {
                for (int i = 0; i < f.Length; i++)
                {
                    string species;
                    float size, weight;

                    Console.Write("\nEnter species for fish " + (i + 1) + ": ");
                    species = Console.ReadLine();

                    if (species.Length <= 7)
                    {
                        species += "\t";
                    }

                    Console.Write("Enter weight for fish " + (i + 1) + ": ");
                    weight = (float)Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter size for fish " + (i + 1) + ": ");
                    size = (float)Convert.ToDecimal(Console.ReadLine());

                    f[i] = new Fish(species, weight, size);
                }
            }

            else // AutoFish TM
            {
                f[0] = new Fish("Gädda\t", 985, 58);
                f[1] = new Fish("Gös\t", 395, 14);
                f[2] = new Fish("Aborre\t", 550, (float)25.5);
                f[3] = new Fish("Laxforell", 719, (float)38.5);
                f[4] = new Fish("Torsk\t", 423, (float)28.7);
            }


            Console.WriteLine("\nSpecies\t\tWeight\t\tLength\t\tPrice\tShipping\n" + 
                "-----------------------------------------------------------------\n");

            foreach (Fish element in f)
            {
                Console.WriteLine(element.ToString());
            }

            Console.ReadKey();
        }


    }
}
