namespace ch04_05
{
    class Seller : Employee
    {
        private double provision;
        private int itemsSold;

        public Seller(string name, int number, double provision, int itemsSold) : base(name, number)
        {
            this.provision = provision;
            this.itemsSold = itemsSold;
        }

        public override int Salary()
        {
            return (int)(GetBaseSalary() * 0.75 + GetProvisionBonus());
        }

        public int GetProvisionBonus()
        {
            return (int)(provision * itemsSold);
        }

        public override string ToString()
        {
            return "Name: " + GetName() +
                "\nNumber: " + GetNumber() +
                "\nSeller" + 
                "\nSalary: " + this.Salary();
        }
    }
}
