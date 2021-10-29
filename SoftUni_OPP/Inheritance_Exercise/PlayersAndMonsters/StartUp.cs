using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight("pesho", 2);
            Console.WriteLine(knight.ToString());
        }
    }
}