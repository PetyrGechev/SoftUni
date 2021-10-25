using System;
using System.Globalization;
using System.Linq;
namespace SelectionSource
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort(input);
            static void SelectionSort(int[] numbers)
            {
                
             
                for (int i = 0; i < numbers.Length; i++)
                {

                    int index = i;
                    int minNumber = int.MaxValue;
                    for (int j = i+1; j < numbers.Length; j++)
                    {
                        if (numbers[j] < numbers[i] && numbers[j] < minNumber)
                        {
                            minNumber = numbers[j];
                            index = j;
                        }
                    }

                    int temp = numbers[i];
                    numbers[i] = numbers[index];
                    numbers[index] = temp;

                }

                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
