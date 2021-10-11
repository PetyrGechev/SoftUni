using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBox_of_String
{
   public class Box<T>
    {
        public Box(T input)
        {
            Input = input;
        }
        public T Input { get; set; }


        public override string ToString()
        {

            return $"{Input.GetType()}: {Input}";
        }
    }
}
