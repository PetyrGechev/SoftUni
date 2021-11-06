using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> visitors = new List<IIdentifiable>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] inputInfo = input.Split();
                if (inputInfo.Length == 3)
                {
                    Person person = new Person(inputInfo[0],inputInfo[1],inputInfo[2]);
                    visitors.Add(person);
                }
                else
                {
                    Robot robot = new Robot(inputInfo[0], inputInfo[1]);
                    visitors.Add(robot);
                }

                input = Console.ReadLine();
            }
            string checkNumbers = Console.ReadLine();
            visitors = visitors.Where(x => x.Id.EndsWith(checkNumbers)).ToList();
            foreach (var item in visitors)
            {
                Console.WriteLine(item.Id);
            }

        }
    }
}
