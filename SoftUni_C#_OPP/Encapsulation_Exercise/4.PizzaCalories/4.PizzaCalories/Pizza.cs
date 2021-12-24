using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.PizzaCalories
{
    class Pizza
    {
      

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = toppings;
        }

        public IReadOnlyCollection<Topping> Toppings => toppings;
        public Dough Dough
        {
            get { return dough; }
            private set
            {
                dough = value; 

            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)||value.Length>15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count==10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public double GetAllCalories()
        {
            double result = dough.GetCaloriesDough() + toppings.Sum(x => x.CalculateToppingCalories());
            return result;

        }

    }
}
