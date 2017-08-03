/* Programmering 2 med C#
 * Exercise 4.1
 * Page 174
 * 
 * Create a class: Rectangle with private members
 * width, height and methods Area() and 
 * Circumference().
 * Add a constructor with same parameter names
 * as the members.
 * 
 * Create a rectangle object in the Main class,
 * print the area and circumference
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;

namespace ch4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(22.1, 33.2);

            Console.WriteLine("Area: " + rect.Area());
            Console.WriteLine("Circumference: " + rect.Circumference());

            Console.ReadLine();
        }
    }

    class Rectangle
    {
        private double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Circumference()
        {
            return width * 2 + height * 2;
        }

        public double Area()
        {
            return width * height;
        }
    }
}
