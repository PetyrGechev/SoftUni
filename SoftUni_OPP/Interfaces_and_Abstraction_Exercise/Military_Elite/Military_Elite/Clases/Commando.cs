using System.Collections.Generic;
using System.Linq;
using System.Text;
using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class Commando:SpecialisedSoldier,ICommando
    {
        private List<Mission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps) :
            base(id, firstName, lastName, salary, corps)
        {
            missions = new List<Mission>();
        }

        public IReadOnlyCollection<IMission> Missions => missions.AsReadOnly();

        public void Add(Mission mission)
        {
            missions.Add(mission);
        }

        public void CompleteMission(string missionName)
        {
            var mission = Missions.FirstOrDefault(x => x.CodeName == missionName);
            mission.State = State.Finished;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}