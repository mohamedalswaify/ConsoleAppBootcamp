using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.OOP
{
    internal class Patient
    {

        public string Name;
        public double Height; // meters
        public double Weight; // kg


        public Patient(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }


        public double GetBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetBodyStatus(double BMI)
        {

            if (BMI <= 18.5)
                return("Under weight");
            else if (BMI <= 25)
                return("Normal weight");

            else if (BMI <= 30)
                return("Over weight");

            else
                return("Obese");

        }



    }
}
