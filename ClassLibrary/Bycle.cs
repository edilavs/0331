using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Bycle : Vehicle
    {
        public override void Drive(double lengthOfWay)
        {
            Millage += lengthOfWay;
        }
    }
}
