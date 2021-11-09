using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Mouse:Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override void EatFood(IFood food, int quantity)
        {
            if (food is Vegetable|| food is  Fruit)
            {
                FoodEaten += quantity;
                Weight += quantity * 0.1;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}