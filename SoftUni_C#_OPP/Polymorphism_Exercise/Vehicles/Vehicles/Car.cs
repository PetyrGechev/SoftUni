using System;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionersConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : 
            base(fuelQuantity, fuelConsumption, airConditionersConsumption)
        {
        }

        public override void Drive(double distance)
        {
            if (CanBeDriven(distance))
            {
                FuelQuantity -= distance * FuelConsumption;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
        }

        protected override bool CanBeDriven(double distance)
        {
            if (distance*FuelConsumption>FuelQuantity)
            {
                return false;
            }

            return true;
        }

        public override void Refuel(double amount)
        {
            FuelQuantity += amount;
        }
    }
}