using System;

namespace ClassLibrary
{
    public class Car
    {
        public string Licenseplate;
        public DateTime Date;

        public Car() { }

        public double Price() => 240;

        public string VehicleType() => "Car";

    }
}
