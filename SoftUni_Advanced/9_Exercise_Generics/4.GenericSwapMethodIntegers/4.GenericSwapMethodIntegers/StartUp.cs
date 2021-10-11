using System;
using System.Collections.Generic;

namespace _4.GenericSwapMethodIntegers
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Box<int> box = new Box<int>(list);
            string[] line = Console.ReadLine().Split();
            int indexOne = int.Parse(line[0]);
            int indexTwo = int.Parse(line[1]);
            box.SwapItems(list, indexOne, indexTwo);
            Console.WriteLine(box.ToString());
        }
    }
}

