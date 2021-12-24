using System;
using System.Collections.Generic;

namespace _6.GenericCountMethodDoubles
{
    public class StartUp
    {
        
            static void Main(string[] args)
            {

                double n = double.Parse(Console.ReadLine());
                var list = new List<double>();
                for (int i = 0; i < n; i++)
                {
                    list.Add(double.Parse(Console.ReadLine()));
                }

                Box<double> box = new Box<double>(list);
                double elementToCompare = double.Parse(Console.ReadLine());
                double result = box.CompareTo(elementToCompare);
                Console.WriteLine(result);
            }
        
    }
}
