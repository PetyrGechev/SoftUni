using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Owl:Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        public override void EatFood(IFood food, int quantity)
        {
            if (food is Meat)
            {
                FoodEaten += quantity;
                Weight += quantity * 0.25;
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