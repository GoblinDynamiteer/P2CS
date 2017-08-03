/* Programmering 2 med C#
 * Exercise 4.4
 * Page 174
 * 
 * Create a class: Circle 
 * Add private member 'radius' with get/set methods
 * Add methods: Circumference() and Area()
 * 
 * Add subclass: Cylinder that inherits class Circle
 * Add private member 'height' with get/set methods
 * Add methods: Volume(), Surface() 
 *  -- Use Circumference() and Area()
 *  
 * Test the classes by letting the user enter a radius
 * and height.
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */

using System;

namespace ch04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, height;
            bool success = false;
            Cylinder cylinder;

            Console.Write("Enter radius of cylinder: ");
            success = double.TryParse(Console.ReadLine(), out radius);

            Console.Write("Enter height of cylinder: ");
            success = double.TryParse(Console.ReadLine(), out height);

            if (success)
            {
                cylinder = new Cylinder(radius, height);
                Console.WriteLine("\nCylinder with radius "
                    + radius + " and height " + height + ":");
                Console.WriteLine("Surface Area: {0:0.00}", cylinder.Surface());
                Console.WriteLine("Volume: {0:0.00}", cylinder.Volume());
            }

            else
            {
                Console.WriteLine("Error!");
            }

            Console.ReadLine();
        }
    }
}
