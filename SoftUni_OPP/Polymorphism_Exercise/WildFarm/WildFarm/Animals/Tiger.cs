using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Tiger:Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override void EatFood(IFood food, int quantity)
        {
            if (food is Meat )
            {
                FoodEaten += quantity;
                Weight += quantity *1;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {this.Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}