using System;
using System.Collections.Generic;
using System.Globalization;
using Military_Elite.Clases;
using Military_Elite.Interfaces;

namespace Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Soldier> soldiers=new Dictionary<string, Soldier>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] inputInfo = input.Split();
                input = Console.ReadLine();
                string id = inputInfo[1];
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];
                

                if (inputInfo[0] == "Private")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                   // Private 1 Peter Johnson 22.22
                   Private @private = new Private(id, firstName, lastName, salary);
                   soldiers.Add(id,@private);
                }
                else if (inputInfo[0] == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    // 3 George Stevenson 100 222 1

                    LieutenantGeneral leGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 5; i < inputInfo.Length; i++)
                    {
                        Private @private = (Private)soldiers[inputInfo[i]];
                        leGeneral.Add(@private);
                    }
                    soldiers.Add(id,leGeneral);
                }
                else if (inputInfo[0] == "Engineer")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);

                    bool isValid = Enum.TryParse(inputInfo[5], out Corps corps);
                    //Engineer 7 Peter Johnson 12.23 Marines Boat 2 Crane 17
                    if (!isValid)
                    {
                     continue;   
                    }

                    Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < inputInfo.Length; i+=2)
                    {
                        string partName = inputInfo[i];
                        int hours = int.Parse(inputInfo[i + 1]);
                        Repair repair = new Repair(partName, hours);
                        engineer.Add(repair);
                    }
                    soldiers.Add(id,engineer);
                }
                else if (inputInfo[0] == "Commando")
                {
                    
                    decimal salary = decimal.Parse(inputInfo[4]);
                    bool isValid = Enum.TryParse(inputInfo[5], out Corps corps);
                    if (!isValid)
                    {
                        continue;
                    }

                    Commando commando = new Commando(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < inputInfo.Length; i += 2)
                    {
                        string missionName = inputInfo[i];

                        bool isValidState = Enum.TryParse(inputInfo[i + 1], out State state);
                        if (!isValidState)
                        {
                            continue;
                        }

                        Mission mission = new Mission(missionName, state);
                        commando.Add(mission);
                        

                    }
                    soldiers.Add(id, commando);

                }
                else if (inputInfo[0] == "Spy")
                {
                    //Spy: "Spy <id> <firstName> <lastName> <codeNumber>"
                    Spy spy = new Spy(id, firstName, lastName, int.Parse(inputInfo[4]));
                    soldiers.Add(id,spy);
                }

            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString());
            }
        }
    }
}
