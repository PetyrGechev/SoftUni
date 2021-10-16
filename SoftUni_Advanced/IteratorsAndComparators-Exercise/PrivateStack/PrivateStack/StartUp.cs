using System;
using System.Linq;

namespace PrivateStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = "";
            Stack<string> Tstack = new Stack<string>();
            while ((command=Console.ReadLine())!="END")
            {
                if (command.Contains("Push"))
                {
                    command = command.Remove(0, 5);

                    string[] commands = command.Split(", ");


                    Tstack.Push(commands);
                }
                else
                {
                    string element = Tstack.Pop();
                    if (element== "No elements")
                    {
                        Console.WriteLine("No elements");
                        continue;
                    }

                    
                }
            }

            foreach (var item in Tstack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Tstack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
