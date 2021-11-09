using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
        public override void EatFood(IFood food, int quantity)
        {
            if (food is Meat|| food is Vegetable)
            {
                FoodEaten += quantity;
                Weight += quantity * 0.3;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
       
    }
}