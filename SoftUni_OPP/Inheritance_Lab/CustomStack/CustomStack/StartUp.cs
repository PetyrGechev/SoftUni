using System;
using System.Collections.Generic;

namespace CustomStack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new List<string>(){ "dada", "dadaee","2222" });
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
