using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
   public  class Person
   {
       private string name;
       private int age;
       public Person(string name, int age)
       {
           this.name = name;
           this.age = age;
       }
       // public string Name { get; set; }
       //public int Age { get; set; }
       public override string ToString()
       {
           return $"Name: {name}, Age: {age} ";
       }
   }
}
