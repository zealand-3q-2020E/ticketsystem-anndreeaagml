using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLibrary
{
   public abstract class Vehicle
    {
        protected string Licenseplate;
        protected DateTime Date;
        public abstract double Price();

        public abstract string VehicleType();
    }
}
