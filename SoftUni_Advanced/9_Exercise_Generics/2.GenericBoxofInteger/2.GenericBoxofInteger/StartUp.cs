﻿using System;

namespace _2.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Box<int> data = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(data.ToString());

            }
        }
    }
}
