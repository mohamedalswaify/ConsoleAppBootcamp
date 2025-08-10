using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.OOP
{
    internal class Student
    {
        public string Name { get; set; }
       // public double Mark;
        public int FullMark;

        public double Mark {


            get { return Mark; }


            set {  Mark = value; }
                
                }



        public Student( string n ,double m ,int f)
        {

            Name = n;
            Mark = m;
            FullMark = f;
            
        }



        public double GetPercentage()
        {
            return Mark /FullMark*100;
        }
        //GetBodyStatus()
        public string GetGrade()
        {
            double percentage= GetPercentage();

            if (percentage >= 85)
               return("Excellent");

            else if (percentage >= 75)
                return ("Very Good");
            else if (percentage >= 65)
                return (" Good");

            else if (percentage >= 50)
                return ("pass");
            else
                return ("Failed");


        }




    }
}
