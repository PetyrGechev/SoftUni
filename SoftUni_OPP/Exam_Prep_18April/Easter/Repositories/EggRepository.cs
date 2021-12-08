using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;

namespace Easter.Repositories
{
    public class EggRepository:IRepository<IEgg>
    {
        private readonly List<IEgg> eggs;
        public EggRepository()
        {
            eggs = new List<IEgg>();
        }

        public IReadOnlyCollection<IEgg> Models => eggs.ToImmutableArray();
        public void Add(IEgg model)
        {
            eggs.Add(model);
        }

        public bool Remove(IEgg model) => eggs.Remove(model);


        public IEgg FindByName(string name)
        {
            var egg = eggs.FirstOrDefault(x => x.Name == name);
            return egg;
        }
    }
}