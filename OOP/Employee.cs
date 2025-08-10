namespace ConsoleAppBootcamp.OOP
{
    internal class Employee
    {
        public string Name;
        public double Salary;


        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;

        }


        public double CalculateAnnualSalary()

        { return Salary * 12; }

        //GetGrade
        public string GetAnnualSalaryLevel()
        {
            double annual = CalculateAnnualSalary();

            if (annual >= 15000)
                return ("High Salary");

            else if (annual >= 10000)
                return ("Normal  Salary");

            else if (annual >= 5000)
                return ("Low  Salary");

            else
                return ("very Low  Salary");

        }

   
    }
}
