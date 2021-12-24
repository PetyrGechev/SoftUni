using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthday> list = new List<IBirthday>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                // Citizen Peter 22 9010101122 10 / 10 / 1990
                // Pet Sharo 13/11/2005
                string[] inputInfo = input.Split();
                if (inputInfo[0]=="Citizen")
                {
                    Citizen person = new Citizen(inputInfo[1], inputInfo[2], inputInfo[3],inputInfo[4]);
                    list.Add(person);
                }
                else if (inputInfo[0] == "Pet")
                {
                    Pet pet = new Pet(inputInfo[1],inputInfo[2]);
                    list.Add(pet);
                }
               

                input = Console.ReadLine();
            }
            string checkNumbers = Console.ReadLine();
            list = list.Where(x => x.Birthday.EndsWith(checkNumbers)).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.Birthday);
            }

        }
    }
}
