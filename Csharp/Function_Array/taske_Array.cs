using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.Function_Array
{
    internal class taske_Array
    {

        public static string[] Task2_StudentGrading(string studentName, double mark, double fullMark)
        {
            Console.WriteLine("Task 2: Student Grading System");
            Console.WriteLine("==============================");

            double percentage = (mark / fullMark) * 100;
            string grade = "";

            if (percentage >= 85) grade = "Grade: Excellent";   
            else if (percentage >= 75) grade = "Grade: Very Good";
            else if (percentage >= 65)grade = "Grade: Good";
            else if (percentage >= 50) grade = "Grade: Pass";
            else grade = "Grade: Failed";

            return new string[] 
            {
            "\nName: " + studentName,
            "Mark: " + mark + " out of " + fullMark,
            "Percentage: " + percentage + " %",
            grade
            };

        }
    
    
    
    
    }
}
