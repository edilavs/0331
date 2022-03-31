using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
       
        

        public string Color { get; set; }
        public string Brand { get; set; }
        public double  Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Color}\n{Brand}\n{Millage}");
        }
        public abstract void Drive(double lengthOfWay);
    }
}
