using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace _1.ListyIterator
{
    public class ListyIterator<T>
    {
        public ListyIterator(params T[] list)
        {
            this.list = new List<T>(list);
            index = 0;
        }

        private List<T> list;
        private int index ;
      

        public bool HasNext()
        {
            if (index < list.Count - 1)
            {
                return true;
            }

            return false;

        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }



            return false;
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(list[index]);

        }

    }
}
