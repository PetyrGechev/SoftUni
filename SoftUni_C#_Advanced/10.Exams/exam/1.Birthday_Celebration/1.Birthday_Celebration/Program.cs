using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _1.Birthday_Celebration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> vowels = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse));
            //Stack<int> consonants = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse));

            //e a u o
            //p r l x f
            string firstInput = Console.ReadLine();
            string inputOneAsStr = firstInput.Replace(" ", "");

            string secondInput = Console.ReadLine();
            string inputTwoAsStr = secondInput.Replace(" ", "");
            string result = inputOneAsStr + inputTwoAsStr;
            
            int counter = 0;
            string wordPear = "pear";
            string wordFlour = "flour";
            string wordPork = "pork";
            string wordOlive = "olive";

            bool p = false;
            bool e = false;
            bool a = false;
            bool r = false;
            bool pearFound = false;

            bool f = false;
            bool l = false;
            bool o = false;
            bool u = false;
            bool flourFound = false;


            bool k = false;
            bool porkFound = false;



            bool i = false;
            bool v = false;
            bool oliveFound = false;





            if (result.Contains('p'))
            {
                p = true;
            }

            if (result.Contains('e'))
            {
                e = true;
            }

            if (result.Contains('a'))
            {
                a = true;
            }

            if (result.Contains('r'))
            {
                r = true;
            }



            if (p && e && a && r)
            {
                counter++;
                pearFound = true;
            }


            if (result.Contains('f'))
            {
                f = true;
            }

            if (result.Contains('l'))
            {
                l = true;
            }

            if (result.Contains('o'))
            {
                o = true;
            }

            if (result.Contains('u'))
            {
                u = true;
            }

            if (result.Contains('r'))
            {
                r = true;
            }



            if (f && l && o && u && r)
            {
                counter++;
                flourFound = true;
            }

            if (result.Contains('p'))
            {
                p = true;
            }

            if (result.Contains('o'))
            {
                o = true;
            }

            if (result.Contains('r'))
            {
                r = true;
            }

            if (result.Contains('k'))
            {
                k = true;

            }

            if (p && o && r && k)
            {
                counter++;
                porkFound = true;
            }




        


            if (result.Contains('o'))
            {
                o = true;
            }

            if (result.Contains('l'))
            {
                l = true;
            }

            if (result.Contains('i'))
            {
                i = true;
            }

            if (result.Contains('v'))
            {
                v = true;
            }

            if (result.Contains('e'))
            {
                e = true;
            }



            if (o && l && i && v && e)
            {
                counter++;
                oliveFound = true;
            }

            Console.WriteLine($"Words found: {counter}");
            if (pearFound)
            {
                Console.WriteLine("pear"); 
            }
            if (flourFound)
            {
                Console.WriteLine("flour");
            }
            if (porkFound)
            {
                Console.WriteLine("pork");
            }
            if (oliveFound)
            {
                Console.Write("olive");
            }
        }
    }
}
