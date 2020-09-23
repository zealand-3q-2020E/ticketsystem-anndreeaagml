using System;

namespace ClassLibrary
{
    public class Car:Vehicle
    {

        public Car() { }

        public override double Price() => 240;

        public override string VehicleType() => "Car";

    }
}
