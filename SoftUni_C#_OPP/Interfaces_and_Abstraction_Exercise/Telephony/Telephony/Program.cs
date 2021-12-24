using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<string> websites= Console.ReadLine().Split().ToList();
            foreach (var number in numbers)
            {
                if (number.Length==10)
                {
                    bool IsNumber = number.Any(x => !char.IsNumber(x));
                    if (IsNumber)
                    {
                        Console.WriteLine($"Invalid number!");
                    }
                    else
                    {
                        Smartphone smartphone = new Smartphone();
                        Console.WriteLine(smartphone.Call(number));
                    }
                }
                else if (number.Length == 7)
                {
                    bool IsNumber = number.Any(x => !char.IsNumber(x));
                    if (IsNumber)
                    {
                        Console.WriteLine($"Invalid number!");
                    }
                    else
                    {
                        StationaryPhone stationaryPhone = new StationaryPhone();
                        Console.WriteLine(stationaryPhone.Call(number));
                    }

                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }
            }

            foreach (var website in websites)
            {
                if (website.Any(x=>char.IsNumber(x)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Smartphone smartphone = new Smartphone();
                    Console.WriteLine(smartphone.Browse(website));
                }
            }
        }
    }
}
