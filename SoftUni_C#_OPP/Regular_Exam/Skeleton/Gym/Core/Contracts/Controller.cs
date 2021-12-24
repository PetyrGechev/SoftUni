using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;

namespace Gym.Core.Contracts
{
    public class Controller : IController
    {
        private readonly EquipmentRepository equipments;
        private readonly Dictionary<string, IGym> gyms;


        public Controller()
        {
            gyms = new Dictionary<string, IGym>();
            equipments = new EquipmentRepository();
        }


        public string AddGym(string gymType, string gymName)
        {
            IGym gym;
            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }
            gyms.Add(gymName, gym);
            return $"Successfully added {gymType}.";
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment;
            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();

            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }
            equipments.Add(equipment);
            return $"Successfully added {equipmentType}.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment equipment = equipments.FindByType(equipmentType);
            IGym gym = gyms[gymName];

            if (equipment == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }
           
            gym.AddEquipment(equipment);
            equipments.Remove(equipment);
            return $"Successfully added {equipmentType} to {gymName}.";
            
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;
            IGym gym = gyms[gymName];
            string gymType = gym.GetType().Name;
            string boxerType;
            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                boxerType = "Boxer";
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                boxerType = "Weightlifter";
            }
            else
            {
                throw new InvalidOperationException($"Invalid athlete type.");
            }

            if ( boxerType== "Boxer" && gymType == "BoxingGym")
            {
                gym.AddAthlete(athlete);
                return $"Successfully added {athleteType} to {gymName}.";
            }

            if (boxerType== "Weightlifter" && gymType== "WeightliftingGym")
            {
                gym.AddAthlete(athlete);
                return $"Successfully added {athleteType} to {gymName}.";
            }

            return $"The gym is not appropriate.";
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = gyms[gymName];
            int athletesCount = gym.Athletes.Count;
            gym.Exercise();
            return $"Exercise athletes: {athletesCount}.";
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = gyms[gymName];
            var value = gym.EquipmentWeight;
            return $"The total weight of the equipment in the gym {gymName} is {value:f2} grams.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.Value.GymInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}