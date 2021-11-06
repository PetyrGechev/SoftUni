using System.Collections.Generic;
using System.Text;
using Military_Elite.Interfaces;

namespace Military_Elite.Clases
{
    public class LieutenantGeneral:Private,ILieutenantGeneral
    {
        private List<IPrivate> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();

        public void Add(Private @private)
        {
            privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( base.ToString());
            sb.AppendLine("Privates:");
            foreach (var item in privates)
            {
                sb.AppendLine($"  {item.ToString()}" );
            }

            return sb.ToString().TrimEnd();
        }
    }
}