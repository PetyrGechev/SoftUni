using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _1.Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<int> sets = new List<int>();
            while (hats.Count>0&&scarfs.Count>0)
            {
                var hat = hats.Peek();
                var scarf = scarfs.Peek();
                int sum = hat + scarf;
                if (hat > scarf)
                {
                    sets.Add(sum);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf>hat)
                {
                    hats.Pop();
                }
                else
                {
                    hats.Push(hats.Pop() + 1);
                    scarfs.Dequeue();
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ",sets));
        }
    }
}
