using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dipping sauce
            //150
            //Green salad
            //250
            //Chocolate cake
            //300
            //Lobster
            //400

            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int dippingSauce = 0;
            int greenSalat = 0;
            int chocolatecake = 0;
            int lobster = 0;
            bool IsSuccsesful = false;

            while (true)
            {
                if (dippingSauce >= 1 && greenSalat >= 1 && chocolatecake >= 1 && lobster >= 1)
                {
                     IsSuccsesful = true;

                }

                if (ingredients.Count <= 0 || freshness.Count <= 0)
                {

                    break;

                }

                int ingridient = ingredients.Peek();
                int freshLevel = freshness.Peek();
               
                int result = ingridient * freshLevel;
           
                if (result == 150)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    dippingSauce++;
                }
                else if (result == 250)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    greenSalat++;
                }
                else if (result == 300)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    chocolatecake++;
                }
                else if (result == 400)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    lobster++;
                }
                else if (ingridient <= 0)
                {
                    ingredients.Dequeue();

                }
                else
                {
                    freshness.Pop();
                    ingridient += 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(ingridient);
                }


            }

            if (IsSuccsesful)
            {

                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");

                Console.WriteLine($"# Chocolate cake --> {chocolatecake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalat}");
                Console.Write($"# Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
                if (ingredients.Sum()>0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                
                if (chocolatecake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolatecake}");
                }

                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                }

                if (greenSalat > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalat}");
                }

                if (lobster > 0)
                {
                    Console.Write($"# Lobster --> {lobster}");
                }
            }
        }
    }
}
