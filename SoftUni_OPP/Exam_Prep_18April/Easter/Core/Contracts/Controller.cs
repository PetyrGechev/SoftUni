using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Repositories;

namespace Easter.Core.Contracts
{
    public class Controller :IController
    {
        private int countColoredEggs = 0;
        public BunnyRepository bunnies;
        public EggRepository eggs;
        public Workshop workshop;
        public Controller()
        {
            bunnies = new BunnyRepository();
            eggs = new EggRepository();
            workshop = new Workshop();
        }
        public string AddBunny(string bunnyType, string bunnyName)
        {
            IBunny bunny;
            if (bunnyType == "HappyBunny")
                bunny = new HappyBunny(bunnyName);
            else if (bunnyType == "SleepyBunny")
                bunny = new SleepyBunny(bunnyName);
           
            else
                throw new InvalidOperationException($"Invalid bunny type.");
            bunnies.Add(bunny);
            return $"Successfully added {bunnyType} named {bunnyName}.";
                
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IDye dye = new Dye(power);
            IBunny bunny = bunnies.FindByName(bunnyName);
            if (bunny==null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }
            bunny.Dyes.Add(dye);
            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);
            eggs.Add(egg);
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            IEgg egg = eggs.FindByName(eggName);
            var readyBunnies=  bunnies.Models.Where(e=>e.Energy>=50).OrderByDescending(x => x.Energy).ToList();
            if (readyBunnies==null)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }
            foreach (var bunni in readyBunnies)
            {
                if (egg.IsDone())
                {
                    break;
                }
                workshop.Color(egg,bunni);

            }

            if (egg.IsDone())
            {
                countColoredEggs++;
                return $"Egg {eggName} is done.";
            }
            else
            {
                return $"Egg {eggName} is not done.";
            }
        }

        public string Report()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{countColoredEggs} eggs are done!");
            sb.AppendLine("Bunnies info:");
            foreach (var bunny in bunnies.Models.Where(x=>x.Energy>0))
            {
                int count = 0;
                foreach (var dye in bunny.Dyes)
                {
                    if (!dye.IsFinished())
                    {
                        count++;
                    }
                }
                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {count} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}