﻿using System;
using _4.MultipleInheritance;

namespace Farm
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
