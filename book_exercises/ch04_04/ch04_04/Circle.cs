using System;

namespace ch04_04
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        /* Constructor */
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
