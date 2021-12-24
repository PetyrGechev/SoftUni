using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Food;

namespace WildFarm
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            while (true)
            {
                try
                {
                    string animalInfo = Console.ReadLine();
                    if (animalInfo == "End")
                    {
                        break;
                    }

                    string foodInfo = Console.ReadLine();
                    string[] animalDetails = animalInfo.Split();
                    string[] foodDetails = foodInfo.Split();
                    string foodName = foodDetails[0];
                    int foodCount = int.Parse(foodDetails[1]);
                    IFood food = null;
                    if (foodName == "Fruit")
                    {
                        food = new Fruit(foodName, foodCount);
                    }
                    else if (foodName == "Meat")
                    {
                        food = new Meat(foodName, foodCount);
                    }
                    else if (foodName == "Seeds")
                    {
                        food = new Seeds(foodName, foodCount);
                    }
                    else if (foodName == "Vegetable")
                    {
                        food = new Vegetable(foodName, foodCount);
                    }

                    string animalType = animalDetails[0];
                    string animalName = animalDetails[1];
                    double animalWeight = double.Parse(animalDetails[2]);
                    if (animalType == "Cat")
                    {
                        string livngRegion = animalDetails[3];
                        string breed = animalDetails[4];
                        Animal cat = new Cat(animalName, animalWeight, livngRegion, breed);
                        Console.WriteLine(cat.ProduceSound());
                        animals.Add(cat);
                        cat.EatFood(food, foodCount);

                    }
                    else if (animalType == "Dog")
                    {
                        string livngRegion = animalDetails[3];
                        Animal dog = new Dog(animalName, animalWeight, livngRegion);
                        Console.WriteLine(dog.ProduceSound());
                        animals.Add(dog);
                        dog.EatFood(food, foodCount);
                    }
                    else if (animalType == "Hen")
                    {
                        double wingSize = double.Parse(animalDetails[3]);
                        Animal hen = new Hen(animalName, animalWeight, wingSize);
                        Console.WriteLine(hen.ProduceSound());
                        animals.Add(hen);
                        hen.EatFood(food, foodCount);
                    }
                    else if (animalType == "Mouse")
                    {
                        string livngRegion = animalDetails[3];
                        Animal mouse = new Mouse(animalName, animalWeight, livngRegion);
                        Console.WriteLine(mouse.ProduceSound());
                        animals.Add(mouse);
                        mouse.EatFood(food, foodCount);
                    }
                    else if (animalType == "Owl")
                    {
                        double wingSize = double.Parse(animalDetails[3]);
                        Animal own = new Owl(animalName, animalWeight, wingSize);
                        Console.WriteLine(own.ProduceSound());
                        animals.Add(own);
                        own.EatFood(food, foodCount);
                    }
                    else if (animalType == "Tiger")
                    {
                        string livngRegion = animalDetails[3];
                        string breed = animalDetails[4];
                        Animal tiger = new Tiger(animalName, animalWeight, livngRegion, breed);
                        Console.WriteLine(tiger.ProduceSound());
                        animals.Add(tiger);
                        tiger.EatFood(food, foodCount);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
