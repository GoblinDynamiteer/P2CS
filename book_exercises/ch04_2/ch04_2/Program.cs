/* Programmering 2 med C#
 * Exercise 4.2
 * Page 174
 * 
 * Modify class Rectangle from exercise 4.1:
 * 
 * Add Get- Set-methods for width and height.
 * Let user enter width and height.
 * 
 * After printing area and circumference, double 
 * width and height. Print area and circumference
 * again. At what factor does the area and circumference
 * grow by?
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;

namespace ch4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            double area, circum;

            Console.Write("Enter height: ");
            rect.Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            rect.Width = Convert.ToDouble(Console.ReadLine());

            /* Store area and circuference */
            area = rect.Area();
            circum = rect.Circumference();

            /* Print area and circumference */
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circum);

            /* Double width and height */
            rect.Width *= 2;
            rect.Height *= 2;

            Console.WriteLine("\nAfter doubling:\nArea: " + rect.Area() + 
                " (x" + rect.Area() / area + ")");
            Console.WriteLine("Circumference: " + rect.Circumference() +
                " (x" + rect.Circumference() / circum + ")");


            Console.ReadLine();
        }
    }

    class Rectangle
    {
        /* Get and Set-methods with intellisense 
         * 'propfull' expand */
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
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
