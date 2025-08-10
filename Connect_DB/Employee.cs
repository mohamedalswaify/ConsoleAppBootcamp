using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppBootcamp.Connect_DB
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double salary { get; set; }


        public override string ToString()
        {
            return $"Id:{Id},Full Name:{Name}, Salary:{salary}";
        }

    }
}
