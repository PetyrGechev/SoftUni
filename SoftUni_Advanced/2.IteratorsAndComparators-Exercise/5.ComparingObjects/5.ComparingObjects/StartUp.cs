using System;
using System.Collections.Generic;

namespace _5.ComparingObjects
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            // Peter 22 Varna
             int equalPeople = -1;
             int notEqualPeople = -1;
        List<Person> people = new List<Person>();
            string command = "";
            while ((command=Console.ReadLine())!="END")
            {
                string[] info = command.Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                string city = info[2];
                Person person = new Person(name, age, city);
                people.Add(person);
            }

            int indexOfPerson = int.Parse(Console.ReadLine())-1;

            foreach (var person in people)
            {
                if (people[indexOfPerson].CompareTo(person)==1)
                {
                    equalPeople++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            Console.WriteLine(equalPeople > 0 ? $"{equalPeople+1} {notEqualPeople+1} {people.Count}" : "No matches");
        }
    }
}
