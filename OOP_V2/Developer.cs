using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.OOP_V2
{
    internal class Developer :Employee
    {

 
        public int OvertimeHours { get; set; }
        public double HourlyRate { get; set; }

        public Developer(string name, double salary, int overtimeHours, double hourlyRate) :base(name,salary)
        {
        
            OvertimeHours = overtimeHours;
            HourlyRate = hourlyRate;
        }

        public override double GetNetSalary()
        {
            return Salary + (OvertimeHours * HourlyRate);
        }
    }
}
