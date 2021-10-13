using System;
using System.Collections.Generic;
using System.Text;

namespace _6.GenericCountMethodDoubles
{

    public class Box<T> where T : IComparable
    {
        public Box(List<T> elements)
        {
            Elements = elements;
        }


        public List<T> Elements { get; }

        public int CompareTo(T elementToCompare)
        {
            int counter = 0;
            foreach (var element in Elements)
            {
                if (elementToCompare.CompareTo(element) < 0
                )
                {
                    counter++;
                }
            }
            return counter;
        }

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
