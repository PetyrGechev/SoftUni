using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        //Create a class Person, which should have public properties with private setters for:
        //    FirstName: string
        //    LastName: string
        //    Age: int

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }



        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }


    }

}
