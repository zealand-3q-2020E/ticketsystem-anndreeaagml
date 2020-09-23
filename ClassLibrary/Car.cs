using System;

namespace ClassLibrary
{
    public class Car:Vehicle
    {

        public Car()
        { }
        public Car(bool hasBrobizz)
        {
            brobizz = hasBrobizz;
        }
        public override double Price()
        {
            if (brobizz == true)
            {
                return 240 * 0.95;
            }
            else
            {
                return 240;
            }
        }

        public override string VehicleType() => "Car";

    }
}
