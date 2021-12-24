using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        // fuel quantity, fuel consumption in liters per km,
        //and can be driven a given distance and refueled with a given amount of fuel.
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public void Drive(double distance);
        public void Refuel(double amount);
    };
}
