using System;
using System.Collections.Generic;

namespace _5.GenericCountMethodStrings
{
  public  class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            Box<string> box = new Box<string>(list);
            string elementToCompare = Console.ReadLine();
            int result = box.CompareTo(elementToCompare);
            Console.WriteLine(result);



        }
    }
}
