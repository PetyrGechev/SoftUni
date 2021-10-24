using System;

namespace _03.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {2, 3, 4, 5};
            Console.WriteLine(SumArray(numbers,0));
            static int  SumArray(int[] arrey,int startIndex)
            {

                if (startIndex==arrey.Length)
                {
                    return 0;
                }

                return arrey[startIndex] + SumArray(arrey, startIndex + 1);
            }

        }
    }
}
