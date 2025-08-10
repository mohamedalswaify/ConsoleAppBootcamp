using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp
{
    internal class Tasks
    {
        public  void Task1_EmployeeSalary(string name, double salary)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Task 1: Employee Salary Levels");
            Console.WriteLine("==============================");

           

            double annual = salary * 12;
            //mark /fullmark *100

            Console.WriteLine("\nEmployee Name:" + name);
            Console.WriteLine("Employee Salary:" + salary);
            Console.WriteLine("Employee Annual Salary :" + annual);

            if (annual >= 15000)
                Console.WriteLine("High Salary");

            else if (annual >= 10000)
                Console.WriteLine("Normal  Salary");

            else if (annual >= 5000)
                Console.WriteLine("Low  Salary");

            else
                Console.WriteLine("very Low  Salary");
        }

        public static void Task2_StudentGrading(string studentName, double mark, double fullMark)
        {
            Console.WriteLine("Task 2: Student Grading System");
            Console.WriteLine("==============================");

          

            double percentage = (mark / fullMark) * 100;

            Console.WriteLine("\nName: " + studentName);
            Console.WriteLine("Mark: " + mark + " out of " + fullMark);
            Console.WriteLine("Percentage: " + percentage + " %");

            if (percentage >= 85)
                Console.WriteLine("Grade: Excellent");
            else if (percentage >= 75)
                Console.WriteLine("Grade: Very Good");
            else if (percentage >= 65)
                Console.WriteLine("Grade: Good");
            else if (percentage >= 50)
                Console.WriteLine("Grade: Pass");
            else
                Console.WriteLine("Grade: Failed");


        }


        public static void Task3_PatientBMI(string patientName, double height, double weight)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("Task 3: Patient BMI Category");
            Console.WriteLine("==============================");


            double bmi = weight / (height * height);

            Console.WriteLine("\nName: " + patientName);
            Console.WriteLine("Height: " + height + " m");
            Console.WriteLine("Weight: " + weight + " kg");
            Console.WriteLine("BMI: " + bmi);

            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal Weight");
            else if (bmi < 30)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
        }


        public static void compute_salary(double salary)
        {

            double annual = salary * 12;
            Console.WriteLine(annual);
        }

        public static double compute_salary2(double salary)
        {

            double annual = salary * 12;
            return(annual);
        }


        public static double Task2_StudentGrading2(string studentName, double mark, double fullMark)
        {
            Console.WriteLine("Task 2: Student Grading System");
            Console.WriteLine("==============================");

            double percentage = (mark / fullMark) * 100;
            return percentage;

        }




        public  string[] Task1_EmployeeSalary2(string name, double salary)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Task 1: Employee Salary Levels");
            Console.WriteLine("==============================");

            double annual = salary * 12;

            string grade = "";

            if (annual >= 15000)  grade = "High Salary";
            else if (annual >= 10000)  grade = "Normal Salary";
            else if (annual >= 5000) grade = "Low Salary";
            else  grade = "very Low Salary";

            return new string[]
                {
                "\nEmployee Name:" + name,
                "Employee Salary:" + salary,
                "Employee Annual Salary :" + annual,
                grade
                };
        }




    }
}
