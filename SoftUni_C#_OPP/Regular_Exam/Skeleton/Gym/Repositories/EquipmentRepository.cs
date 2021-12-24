using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Gym.Models.Equipment.Contracts;
using Gym.Repositories.Contracts;

namespace Gym.Repositories
{
    public class EquipmentRepository:IRepository<IEquipment>
    {
        private readonly List<IEquipment> equipments;

        public EquipmentRepository()
        {
            equipments = new List<IEquipment>();
        }
        public IReadOnlyCollection<IEquipment> Models => equipments.ToImmutableArray();
        public void Add(IEquipment model)
        {
            equipments.Add(model);
        }

        public bool Remove(IEquipment model) => equipments.Remove(model);

        public IEquipment FindByType(string type)
        {
            var result= equipments.FirstOrDefault(x =>x.GetType().Name==type);
            return result;
        }
    }
}