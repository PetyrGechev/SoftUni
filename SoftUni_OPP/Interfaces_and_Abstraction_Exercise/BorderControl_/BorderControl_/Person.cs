using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl_
{
    public class Person : IPerson
    {
        public Person(string name, string age, string id)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }
        public string Age { get; private  set; }

        
    }
}
