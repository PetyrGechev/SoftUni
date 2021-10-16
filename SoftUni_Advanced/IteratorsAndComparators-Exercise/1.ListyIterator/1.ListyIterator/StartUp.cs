using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _1.ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command ="";
            ListyIterator<string> listy = null;
            while ((command=Console.ReadLine()) != "END")
            {
                
                string[] commands = command.Split();
                if (commands[0]=="Create")
                {
                    listy = new ListyIterator<string>(commands.Skip(1).ToArray());
                }
                else if (commands[0] == "Print")
                {
                    listy.Print();
                    
                }
                else if (commands[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (commands[0] == "HasNext")
                {   

                    Console.WriteLine(listy.HasNext());
                }
                else if (commands[0] == "PrintAll")
                {

                    listy.PrintAll();
                }


            }

        }
    }
}
