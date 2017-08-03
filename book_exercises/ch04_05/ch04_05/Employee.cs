namespace ch04_05
{
    class Employee
    {
        private string name;
        private int number;
        private int salary = 25000;

        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public int GetBaseSalary()
        {
            return salary;
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumber()
        {
            return number;
        }

        public virtual int Salary()
        {
            return salary;
        }

        public override string ToString()
        {
            return "Name: " + name + 
                "\nNumber: " + number +
                "\nSalary: " + Salary();
        }

    }
}
