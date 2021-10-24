using System;

namespace _02.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFactoriel(5));
            static int GetFactoriel(int number)
            {
                
                if (number==0)
                {
                    return 1;
                }

                return number * GetFactoriel(number - 1);

            }
        }
    }
}
