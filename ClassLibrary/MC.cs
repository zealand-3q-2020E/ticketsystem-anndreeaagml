using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class MC:Vehicle
    {

        public MC() { }
        public MC(bool hasBrobizz)
        {
            brobizz = hasBrobizz;
        }
        public override double Price()
        {
            if (brobizz == true)
            {
                return 125 * 0.95;
            }
            else
            {
                return 125;
            }
        }

        public override string VehicleType() => "MC";
    }
}
