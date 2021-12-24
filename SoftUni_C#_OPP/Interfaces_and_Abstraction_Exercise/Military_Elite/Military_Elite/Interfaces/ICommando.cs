using System.Collections.Generic;
using System.Linq;
using Military_Elite.Clases;

namespace Military_Elite.Interfaces
{
    public interface ICommando:ISpecialisedSoldier
    {
        public IReadOnlyCollection<IMission> Missions { get; }

        public void CompleteMission(string missionName);


    }
}