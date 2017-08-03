namespace ch04_05
{
    class PermEmployee : Employee
    {
        public PermEmployee(string name, int number) 
            : base(name, number) { }

        public override int Salary()
        {
            return GetBaseSalary() + 2000; 
        }

        public override string ToString()
        {
            return "Name: " + GetName() +
                "\nNumber: " + GetNumber() +
                "\nPermanen Employee" + 
                "\nSalary: " + this.Salary();
        }
    }
}
