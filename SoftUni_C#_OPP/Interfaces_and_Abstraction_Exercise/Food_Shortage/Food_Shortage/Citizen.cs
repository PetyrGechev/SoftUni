using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public class Citizen : ICitizen,IBuyer
    {
        public Citizen(string name, string age, string id,string birthday)
        {
            Name = name;
            Id = id;
            Age = age;
            Birthday = birthday;

        }

        public string Name { get; private set; }

        public string Id { get; private set; }
        public string Age { get; private  set; }


        public string Birthday { get; private set; }
        public void BuyFood()
        {
            Food += 10;
        }

        public int Food { get; private set; }
    }
}
