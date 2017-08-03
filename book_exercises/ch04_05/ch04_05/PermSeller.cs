using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_05
{
    class PermSeller : Seller
    {
        public PermSeller(string name, int number, double provision, int itemsSold)
            : base(name, number, provision, itemsSold) { }

        public override int Salary()
        {
            return (int)GetBaseSalary() + GetProvisionBonus() + 1000;
        }

        public override string ToString()
        {
            return "Name: " + GetName() +
                "\nNumber: " + GetNumber() +
                "\nPermanent Seller" + 
                "\nSalary: " + this.Salary();
        }
    }
}
