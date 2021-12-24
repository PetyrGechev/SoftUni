using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Repositories
{
    public class PlanetRepository
    {
        private readonly List<IPlanet> planets;
        public PlanetRepository()
        {
            planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => planets.ToImmutableArray();
        public void Add(IPlanet model)
        {
            planets.Add(model);
        }

        public bool Remove(IPlanet model) => planets.Remove(model);


        public IPlanet FindByName(string name)
        {
            var planet = planets.FirstOrDefault(x => x.Name == name);
            return planet;
        }
    }
}