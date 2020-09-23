using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLibrary
{
   public abstract class Vehicle
    {
        public string Licenseplate;
        public DateTime Date;
        public bool brobizz=false;

        public Vehicle() { }

        
        public void SetLicencePlate(string licenceplate)
        {
            if (licenceplate.Length <= 7)
            {
                Licenseplate = licenceplate;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public abstract double Price();

        public abstract string VehicleType();
    }
}
