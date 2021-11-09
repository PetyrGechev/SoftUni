namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelConsumption;
        private double additionalFualCompAirCon;
        public Vehicle(double fuelQuantity, double fuelConsumption, double additionalFualCompAirCon)
        {
            this.additionalFualCompAirCon = additionalFualCompAirCon;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
    

        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set
            {
                
                fuelConsumption=value+additionalFualCompAirCon ;
            }

        }
        public abstract void Drive(double distance);
        protected abstract bool CanBeDriven(double distance);

        public abstract void Refuel(double amount);

    }
}