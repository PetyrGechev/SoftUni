using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new Dictionary<string, Car>();
        }

        private Dictionary<string, Car> Participants;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void Add(Car car)
        {
            if (!Participants.ContainsKey(car.LicensePlate) && Count < Capacity && car.HorsePower <= MaxHorsePower)
            {

                Participants.Add(car.LicensePlate, car);
            }
        }

        public bool Remove(string licensePlate)
        {
            if (Participants.ContainsKey(licensePlate))
            {
                Participants.Remove(licensePlate);
                return true;
            }


            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            Car newCar = null;
            foreach (var car in Participants)
            {
                if (car.Key==licensePlate)
                {
                    newCar = car.Value;
                }
            }

            return newCar;

        }

        public Car GetMostPowerfulCar()
        {
             Participants.OrderByDescending(x => x.Value.HorsePower);
            return Participants.FirstOrDefault().Value;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.Value.ToString());
            }

            return sb.ToString().TrimEnd();

        }



    }
}
