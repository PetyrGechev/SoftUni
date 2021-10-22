using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Birthday_Celebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> allGuests = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> allFood = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            
            int wastedFood = 0;
            while (allFood.Any() && allGuests.Any())
            {
                int foodPeek = allFood.Peek();
                int guestPeek = allGuests.Peek();
                if (guestPeek > foodPeek)
                {
                    //3 18 1 9 30 4   food-S
                    // 5 28 1 4  guests -Q
                     
                    int guest = allGuests.Dequeue();
                    guest -= allFood.Pop();
                    Queue<int> tempQue = new Queue<int>();
                    tempQue.Enqueue(guest);
                    for (int i = 0; i < allGuests.Count; i++)
                    {
                        tempQue.Enqueue(allGuests.Dequeue());
                        i--;
                    }

                    allGuests = tempQue;
                }
                else if (foodPeek>=guestPeek)
                {
                   int food= allFood.Pop();
                    int guest=  allGuests.Dequeue();
                    wastedFood += food - guest;
                }
            }

            if (allFood.Any())
            {
                Console.WriteLine($"Plates: {string.Join(" ",allFood)}");
                
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", allGuests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
