using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _5.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        // Peter 22 Varna

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0 && this.Age.CompareTo(other.Age) == 0&& this.City.CompareTo(other.City) == 0)
            {
                return 1;
            }

            return -1;


            
        }
    }
}
