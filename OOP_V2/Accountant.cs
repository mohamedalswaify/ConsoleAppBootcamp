using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.OOP_V2
{
    internal class Accountant :Employee
    {

        public double TaxDeduction { get; set; }
        public Accountant(string name, double salary, double taxDeduction) :base(name,salary)
        {
       
            TaxDeduction = taxDeduction;
        }


        public override double GetNetSalary()
        {
            return Salary - TaxDeduction;
        }


    }
}
