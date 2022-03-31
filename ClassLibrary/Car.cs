using System;

namespace ClassLibrary
{
    public class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;

        
        public override void Drive(double lengthOfWay)
        {
            if (CurrentFuel >= (lengthOfWay * FuelFor1km))
            {
                CurrentFuel -= lengthOfWay * FuelFor1km;
                Millage += lengthOfWay;
            }
        }
       
    }
}
