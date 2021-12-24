using System;

namespace _01.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(10);
            static void Print(int n )
            {
                if (n==-1)
                {
                    return ;
                }
                Console.WriteLine(n);
                Print(n-1);
                Console.WriteLine(n);
            }
        }
    }
}
