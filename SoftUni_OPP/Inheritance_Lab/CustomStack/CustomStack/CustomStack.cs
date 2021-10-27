using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack:Stack<string>
    {
        public bool IsEmpty()
        {
            return Count>0;
        }

        public void AddRange (List<string> list)
        {

            foreach (var element in list)
            {
                Push(element);
            }
        }
    }
}
