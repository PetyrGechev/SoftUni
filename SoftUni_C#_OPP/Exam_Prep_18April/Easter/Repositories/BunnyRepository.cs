using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Easter.Models.Bunnies.Contracts;
using Easter.Repositories.Contracts;

namespace Easter.Repositories
{
    public class BunnyRepository:IRepository<IBunny>
    {
        private readonly List<IBunny> bunnies;
        public BunnyRepository()
        {
            bunnies = new List<IBunny>();
        }

        public IReadOnlyCollection<IBunny> Models => bunnies.ToImmutableArray();
        public void Add(IBunny model)
        {
            bunnies.Add(model);
        }

        public bool Remove(IBunny model) => bunnies.Remove(model);


        public IBunny FindByName(string name)
        {
            var bunny = bunnies.FirstOrDefault(x => x.Name == name);
            return bunny;
        }
    }
}