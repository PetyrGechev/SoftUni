using System;

namespace _4.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {   


                string[] pizzaInput = Console.ReadLine().Split();
                string pizzaName = pizzaInput[1];
                
                string inputDough = Console.ReadLine();


               
                string[] doughInfo = inputDough.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string flourType = doughInfo[1];
                string bakingTehnique = doughInfo[2];
                double doughWeight = double.Parse(doughInfo[3]);
                Dough dough = new Dough(flourType, bakingTehnique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough);


                while (true)
                {

                    string inputTopping = Console.ReadLine();
                    if (inputTopping=="END")
                    {
                        break;
                    }
                    string[] toppingInfo = inputTopping.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingInfo[1];
                    double toppingWeight = double.Parse(toppingInfo[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);

                    
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetAllCalories():f2} Calories.");


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);


            }
            //Dough White Chewy 100
        }
    }
}
