using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp.OOP
{
    internal class Room
    {
     private   double _width;
     public   double length { get; set; }


        //prop

        public double Width 
        {
            set
            {

                if (value >= 0) _width = value;
                else
                    Console.WriteLine("Invalid");
            }
            get
            {
                return _width;
            }
        }



        //public double GetWidth()
        //{ 
        //    return _width; 
        //}




        //public void SetWidth(double w)
        //{
        //    if (w >= 0) _width = w;
        //    else
        //        Console.WriteLine("Invalid");
        //}


        public Room(double w,double l)
        { 
         _width = w;
         length = l;
        }





        public double GetVolume()
        { 
        
        return _width* length;
        }


    }


    

}
