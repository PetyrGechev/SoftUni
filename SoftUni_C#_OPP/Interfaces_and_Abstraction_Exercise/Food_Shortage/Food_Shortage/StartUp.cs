using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string,IBuyer> buyers = new Dictionary<string,IBuyer>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string info = Console.ReadLine();
                string[] inputInfo = info.Split();
                if (inputInfo.Length == 4)
                {
                    Citizen person = new Citizen(inputInfo[0], inputInfo[1], inputInfo[2], inputInfo[3]);
                    buyers.Add(inputInfo[0], person);
                }
                else
                {
                    Rebel rebel = new Rebel(inputInfo[0], inputInfo[1], inputInfo[2]);
                    buyers.Add(inputInfo[0], rebel);
                }
            }

            string input = Console.ReadLine();
            while (input!="End")
            {
                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }

                input = Console.ReadLine();
            }

            int result = buyers.Sum(x => x.Value.Food);
            Console.WriteLine(result);




        }
    }
}
