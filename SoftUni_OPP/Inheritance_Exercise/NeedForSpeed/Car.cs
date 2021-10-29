using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle

    {
        public Car(int hoersePower, double fuel) : base(hoersePower, fuel)
        {
        }
        private double DefaultFuelConsumption = 3;

        public override double FuelConsumption
            => DefaultFuelConsumption;

    }
}
