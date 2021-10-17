using System;
using System.Linq;

namespace _4.Froggy
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Lake<int> lake = new Lake<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
