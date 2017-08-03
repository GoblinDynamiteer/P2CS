namespace ch04_04
{
    class Cylinder : Circle // Inherit Circle Class
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        /* Constructor, call base (Circle class) constructor for radius */
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public double Volume()
        {
            return Area() * height; // Area method from inherited Circle class
        }

        public double Surface()
        {
            return 2 * Area() + Circumference() * height;
        }
    }
}
