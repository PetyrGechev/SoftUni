using System;
using System.Collections.Generic;
using System.Linq;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> cars;

        public CarRepository()
        {
            cars = new List<ICar>();
        }
        public IReadOnlyCollection<ICar> Models
        {
            get => cars.AsReadOnly();
        }
        public void Add(ICar model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
                
            }
            cars.Add(model);
        }

        public bool Remove(ICar model) => cars.Remove(model);
       

        public ICar FindBy(string property)
        {
            ICar car = cars.FirstOrDefault(x => x.VIN == property);
            return car;
        }
    }
}