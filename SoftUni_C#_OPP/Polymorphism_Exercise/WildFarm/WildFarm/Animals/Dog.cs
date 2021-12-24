using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override void EatFood(IFood food, int quantity)
        {
            if (food is Meat)
            {
                FoodEaten += quantity;
                Weight += quantity * 0.4;
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