using System.Collections.Generic;
using System.Text;
using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class Engineer:SpecialisedSoldier,IEngineer
    {
        private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<Repair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => repairs.AsReadOnly();

        public void Add(Repair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Repairs:");
            foreach (var item in Repairs)
            {
                sb.AppendLine($" {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}