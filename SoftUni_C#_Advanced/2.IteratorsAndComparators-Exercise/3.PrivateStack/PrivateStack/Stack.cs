using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrivateStack
{
    public class Stack<T> :IEnumerable<T>
    {
        private int index;
        private List<T> collection;

        public Stack(params T[] data)
        {
            collection = new List<T>(data);
            index = 0;
        }

        public void Push(params T[] elements)
        {
            collection.AddRange(elements);

        }

        public string Pop()
        {
            
            if (!collection.Any())
            {
                 return ($"No elements");
                  


            }
            string element = collection.LastOrDefault().ToString();
            collection.RemoveAt(collection.Count-1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
