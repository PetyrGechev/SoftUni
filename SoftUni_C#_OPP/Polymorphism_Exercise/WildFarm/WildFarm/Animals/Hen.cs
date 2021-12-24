using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Hen:Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override void EatFood(IFood food, int quantity)
        {
            if (food is IFood)
            {
                FoodEaten += quantity;
                Weight += quantity * 0.35;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}