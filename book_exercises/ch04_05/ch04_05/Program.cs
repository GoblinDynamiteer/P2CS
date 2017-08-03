/* Programmering 2 med C#
 * Exercise 4.5
 * Page 174
 * 
 * Create class Employee with method Salary() to show salary.
 * 
 * Create subclasses: PermEmployee, Seller, HourlyEmployee
 * Add data members as you see fit
 * Add polymorphed Salary() methods to all subclasses
 * 
 * Add sublcass PermSeller that inherits class Seller
 * 
 * Add ToString() method that shows employee type, name, employment-number
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;

namespace ch04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            PermEmployee    emp1 = new PermEmployee("Charles Johnsson", 12);
            Seller          emp2 = new Seller("Linda Bengtsson", 21, 0.02, 2000);
            HourlyEmployee  emp3 = new HourlyEmployee("Jonas Svensson", 15, 50);
            PermSeller      emp4 = new PermSeller("Hans Lind", 82, 0.03, 1200);

            Console.WriteLine("Employees: ");
            Console.WriteLine(emp1.ToString() + "\n");
            Console.WriteLine(emp2.ToString() + "\n");
            Console.WriteLine(emp3.ToString() + "\n");
            Console.WriteLine(emp4.ToString() + "\n");

            Console.ReadLine();
        }
    }
}
