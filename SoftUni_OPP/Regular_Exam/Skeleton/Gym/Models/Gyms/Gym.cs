using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private readonly List<IEquipment> equipments;
        private readonly List<IAthlete> athletes;

        protected Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            equipments = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }

                name = value;
            }

        }

        public int Capacity { get; protected set; }


        public double EquipmentWeight
        {
            get => equipments.Sum(x => x.Weight);
        }


        public ICollection<IEquipment> Equipment
        {
            get => equipments;
        }

        public ICollection<IAthlete> Athletes
        {
            get => athletes;
        }

        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }

            athletes.Add(athlete);
        }

        public bool RemoveAthlete(IAthlete athlete) => athletes.Remove(athlete);

        public void AddEquipment(IEquipment equipment)
        {
            equipments.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()                       //!!!!!!!!!!!!!!!!!!!!
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} is a {GetType().Name}:");
            if (!athletes.Any())
            {
                sb.Append($"Athletes: ");
                sb.AppendLine("No athletes");
                sb.AppendLine($"Equipment total count: {equipments.Count}");
                sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");
            }
            else
            {
                List<string> names = new List<string>();
                foreach (var athlete in Athletes)
                {
                    names.Add(athlete.FullName);
                }

                sb.Append($"Athletes: ");
                sb.AppendLine(String.Join(", ", names));
                sb.AppendLine($"Equipment total count: {equipments.Count}");
                sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");

            }
            return sb.ToString().TrimEnd();
        }
    }
}
