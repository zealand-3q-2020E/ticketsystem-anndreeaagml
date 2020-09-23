using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class MC:Vehicle
    {

        public MC() { }

        public override double Price() => 125;

        public override string VehicleType() => "MC";
    }
}
