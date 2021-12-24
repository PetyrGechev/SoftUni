using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int hoersePower, double fuel) : base(hoersePower, fuel)
        {

        }

        private double DefaultFuelConsumption = 8;
        public override double FuelConsumption
            => DefaultFuelConsumption;

    }
}