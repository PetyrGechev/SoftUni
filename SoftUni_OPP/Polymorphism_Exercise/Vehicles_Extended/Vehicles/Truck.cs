using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double additionalFualCompAirCon = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) :
            base(fuelQuantity, fuelConsumption, additionalFualCompAirCon)
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
            if (distance * FuelConsumption > FuelQuantity)
            {
                return false;
            }

            return true;
        }

        public override void Refuel(double amount)
        {
            FuelQuantity += amount*0.95;
        }
    }
}