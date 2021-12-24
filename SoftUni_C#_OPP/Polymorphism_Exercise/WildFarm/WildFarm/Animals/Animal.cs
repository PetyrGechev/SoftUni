using System.ComponentModel.DataAnnotations;
using WildFarm.Food;
namespace WildFarm.Animals
{
    public abstract class Animal:IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public virtual string ProduceSound()
        {
            return "";
        }

        public virtual void EatFood(IFood food, int quantity)
        {
        }
    }
}