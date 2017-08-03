namespace ch04_05
{
    class HourlyEmployee : Employee
    {
        private int hours;

        public HourlyEmployee(string name, int number, int hours) 
            : base(name, number)
            {
                this.hours = hours;
            }

        public override int Salary()
        {
            return (int)(GetBaseSalary() / (40 * 4) * hours);
        }

        public override string ToString()
        {
            return "Name: " + GetName() +
                "\nNumber: " + GetNumber() +
                "\nHourly Employee" + 
                "\nSalary: " + this.Salary();
        }
    }
}
