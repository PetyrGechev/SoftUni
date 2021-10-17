using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _4.Froggy
{
    public class Lake<T> : IEnumerable<int>
    {
        public Lake(params int[] stones)
        {
            this.stones = stones;
        }

        private int[] stones;


        public IEnumerator<int> GetEnumerator()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < stones.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];

                }
            }

            for (int i = stones.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];

                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}