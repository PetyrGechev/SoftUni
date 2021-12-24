using System;
using System.Collections.Generic;
using System.Text;

namespace _4.GenericSwapMethodIntegers
{

    public class Box<T>
    {
        public Box(List<T> elements)
        {
            Elements = elements;
        }


        public List<T> Elements { get; }

        public void SwapItems(List<T> elements, int indexOne, int indexTwo)
        {
            T tempElement = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = tempElement;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }

            return sb.ToString().TrimEnd();
            //return $"{Input.GetType()}: {Input}";
        }
    }
}

