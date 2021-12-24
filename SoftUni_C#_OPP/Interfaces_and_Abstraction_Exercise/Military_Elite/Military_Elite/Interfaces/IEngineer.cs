using System.Collections.Generic;

namespace Military_Elite.Interfaces
{
    public interface IEngineer:ISpecialisedSoldier
    {
        public IReadOnlyCollection<IRepair> Repairs { get; }
    }
}