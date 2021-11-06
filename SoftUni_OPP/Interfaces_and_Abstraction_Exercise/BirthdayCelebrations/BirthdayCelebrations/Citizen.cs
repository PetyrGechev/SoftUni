using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : ICitizen
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
    }
}
