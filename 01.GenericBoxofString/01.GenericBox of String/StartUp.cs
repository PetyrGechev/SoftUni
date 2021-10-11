using System;

namespace _01.GenericBox_of_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                Box<string> data = new Box<string>(Console.ReadLine());
                Console.WriteLine(data.ToString());

            }
        }
    }
}
