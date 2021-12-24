using System.Globalization;

namespace WildFarm.Animals
{
    public interface IAnimal
    {
        //Animal – string Name, double Weight, int FoodEaten
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
       
    }
}