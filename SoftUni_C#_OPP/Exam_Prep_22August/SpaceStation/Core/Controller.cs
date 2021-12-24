using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        public AstronautRepository astronauts;
        public PlanetRepository planets;
        public Mission mission;
        public int visitedPlanets = 0;

        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
            mission = new Mission();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;
            if (type == "Biologist")
                astronaut = new Biologist(astronautName);
            else if (type == "Geodesist")
                astronaut = new Geodesist(astronautName);
            else if (type == "Meteorologist")
                astronaut = new Meteorologist(astronautName);
            else
                throw new InvalidOperationException($"Astronaut type doesn't exists!");
            astronauts.Add(astronaut);
            return $"Successfully added {astronaut.GetType().Name}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var planet = new Planet(planetName);
            foreach (var item in items) planet.Items.Add(item);
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = astronauts.FindByName(astronautName);
            if (astronaut == null) throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");

            astronauts.Remove(astronaut);
            return $"Astronaut {astronautName} was retired!";
        }

        public string ExplorePlanet(string planetName)
        {
            var astronautsOnMission = new List<IAstronaut>();
            var planet = planets.FindByName(planetName);
            foreach (var astronaut in astronauts.Models)
            {
                if (!astronauts.Models.Any(x => x.Oxygen > 60))
                    throw new InvalidOperationException("You need at least one astronaut to explore the planet");
                if (astronaut.Oxygen > 60) astronautsOnMission.Add(astronaut);
            }

            mission.Explore(planet, astronautsOnMission);
            visitedPlanets++;
            var deadAstronauts = astronautsOnMission.Count(x => !x.CanBreath);
            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{visitedPlanets} planets were explored!");
            sb.AppendLine($"Astronauts info:");
            foreach (var astronaut in astronauts.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                sb.Append($"Bag items: ");
                if (!astronaut.Bag.Items.Any())
                    sb.AppendLine("none");
                else
                    sb.AppendLine(string.Join(", ", astronaut.Bag.Items));
            }

            return sb.ToString().TrimEnd();
        }
    }
}