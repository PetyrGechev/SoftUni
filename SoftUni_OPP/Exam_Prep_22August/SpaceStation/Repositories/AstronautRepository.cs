using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
    public class AstronautRepository:IRepository<IAstronaut>
    {
        private readonly List<IAstronaut> astronauts;
        public AstronautRepository()
        {
            astronauts = new List<IAstronaut>();
        }

        public IReadOnlyCollection<IAstronaut> Models => astronauts.ToImmutableArray();
        public void Add(IAstronaut model)
        {
            astronauts.Add(model);
        }

        public bool Remove(IAstronaut model) => astronauts.Remove(model);
       

        public IAstronaut FindByName(string name)
        {
            var astronaut = astronauts.FirstOrDefault(x => x.Name == name);
            return astronaut;
        }
    }
}