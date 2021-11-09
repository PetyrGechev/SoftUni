using System;
using System.Data;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            //"Car {fuel quantity} {liters per km}"
            string[] carInfo = Console.ReadLine().Split(" ");
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split(" ");
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] commandInfo = Console.ReadLine().Split();
                    if (commandInfo[0] == "Drive")
                    {
                        if (commandInfo[1] == "Car")
                        {
                            double distance = double.Parse(commandInfo[2]);
                            car.Drive(distance);
                            Console.WriteLine($"Car travelled {distance} km");
                        }
                        else if (commandInfo[1] == "Truck")
                        {

                            double distance = double.Parse(commandInfo[2]);
                            truck.Drive(distance);
                            Console.WriteLine($"Truck travelled {distance} km");
                        }

                    }
                    else if (commandInfo[0] == "Refuel")
                    {
                        if (commandInfo[1] == "Car")
                        {
                            double amountFuel = double.Parse(commandInfo[2]);
                            car.Refuel(amountFuel);
                        }
                        else if (commandInfo[1] == "Truck")
                        {

                            double amountFuel = double.Parse(commandInfo[2]);
                            truck.Refuel(amountFuel);
                        }

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
               
                }

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");


        }


        
        }
}

