using NUnit.Framework;
using  System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Ford", "Mondeo", 2.5, 50)]
        [TestCase("Ford", "Ka", 3.5, 80)]
        [TestCase("WV", "Polo", 3, 60)]

        public void Ctor_ShoudWorksProperlyWhenDataIsCorrect(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            string CarMake = car.Make;
            string CarMadel = car.Model;
            double CarFuelConsumption = car.FuelConsumption;
            double CarFuelCapacity = car.FuelCapacity;

            Assert.That(CarMake, Is.EqualTo(make));
            Assert.That(CarMadel, Is.EqualTo(model));
            Assert.That(CarFuelConsumption, Is.EqualTo(fuelConsumption));
            Assert.That(CarFuelCapacity, Is.EqualTo(fuelCapacity));
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [TestCase("Ford", "Ka", 3.5, 80)]
        [TestCase("Ford", "Mondeo", 2.5, 50)]
        [TestCase("WV", "Polo", 3, 60)]

        public void Ctor_ShoudSetCarFuelTo0(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            double carFuel = car.FuelAmount;
            Assert.That(carFuel, Is.EqualTo(0));
        }

        [TestCase("", "Mondeo", 2.5, 50)]
        [TestCase(null, "Ka", 3.5, 80)]

        public void Make_ShoudNotBeNullOrEmpty(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = null;
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));

        }

        [TestCase("Ford", "", 2.5, 50)]
        [TestCase("Ford", null, 3.5, 80)]

        public void Model_ShoudNotBeNullOrEmpty(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = null;
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));

        }

        [TestCase("Ford", "22", 0, 50)]
        [TestCase("Ford", "dd", -2, 80)]

        public void FuelConsumptionCannotBeZeroOrNegative(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = null;
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));

        }

        //    [TestCase("Ford", "Mondeo", 5, 50)]
        //    [TestCase("Ford", "Ka", 2, 80)]

        //    public void FuelAmountCannotBeNegative(string make, string model, double fuelConsumption, double fuelCapacity)
        //    {
        //        Car car = new Car(make, model, fuelConsumption, fuelCapacity);


        //        Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));

        //    }
        [TestCase("Ford", "22", 2, 0)]
        [TestCase("Ford", "dd", 4, -2)]

        public void FuelCapacityCannotBeZeroOrNegative(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = null;
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));

        }

        [TestCase(0)]
        [TestCase(-20)]

        public void Refuel_FuelAmountCannotBeZeroOrNegative(double fuelAmount)
        {
            Car car = new Car("dd", "d2", 2, 27);
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelAmount));

        }
        [TestCase(20)]
        [TestCase(10)]

        public void Refuel_ShoudAddTheRightAmountOFFue(double fuelAmount)
        {
            Car car = new Car("dd", "d2", 2, 50);
            car.Refuel(fuelAmount);
            Assert.That(car.FuelAmount, Is.EqualTo(fuelAmount));

        }

        [TestCase(40)]
        [TestCase(50)]

        public void Refuel_ShoudNotAddMoreThanTheCapacity(double fuelAmount)
        {
            Car car = new Car("dd", "d2", 2, 30);
            car.Refuel(fuelAmount);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));

        }

        [TestCase("Ford", "Ka", 10, 4,150)]
        [TestCase("Ford", "Mondeo", 10, 10,100)]

        public void Drive_ShoudThrowExceptionWhenNotEnoughFuel(string make, string model, double fuelConsumption, double fuelCapacity,double distance)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            
            Assert.Throws<InvalidOperationException>(()=>car.Drive(distance));
        }
       
        [TestCase("Ford", "Mondeo", 10, 15, 100)]

        public void Drive_ShoudUseTheRighAMounfOFFuel(string make, string model, double fuelConsumption, double fuelCapacity, double distance)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(15);
            car.Drive(distance);
            Assert.That(car.FuelAmount,Is.EqualTo(5));
        }




    }



}
