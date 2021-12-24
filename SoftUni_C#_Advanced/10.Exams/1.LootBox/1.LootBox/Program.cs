using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> collection = new List<int>();
            while (firstBox.Any()&&secondBox.Any())
            {
                int firstBoxNum = firstBox.Peek();
                int secondBoxNum = secondBox.Peek();
                int sum = firstBoxNum + secondBoxNum;
                if (sum%2==0)
                {
                    collection.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(firstBoxNum);
                }


            }

            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (collection.Sum()>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection.Sum()}");
            }
        }
    }
}
