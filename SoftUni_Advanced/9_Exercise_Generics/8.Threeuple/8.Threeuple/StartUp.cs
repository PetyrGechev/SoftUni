using System;

namespace _8.Threeuple
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();
            string[] thirdLine = Console.ReadLine().Split();
            //{first name} {last name} {address}
            string firstName = firstLine[0];
            string lastName = firstLine[1];
            string fullName = firstName + " " + lastName;
            string adress = firstLine[2];
            string town = firstLine[3];
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(fullName, adress, town);
            //{name} {liters of beer}
            string name = secondLine[0];
            double litersOfbeer = double.Parse(secondLine[1]);
            bool drunkOrNot;
            if (secondLine[2]=="drunk")
            {
                drunkOrNot = true;
            }
            else
            {
                drunkOrNot = false;
                
            }

            Threeuple<string, double, bool> threeuple2 =
                new Threeuple<string, double, bool>(name, litersOfbeer, drunkOrNot);

            //{integer} {double}
            string nameTwo = thirdLine[0];
            double AcountBalance = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];
            Threeuple<string, double, string> threeuple3 =
                new Threeuple<string, double, string>(nameTwo, AcountBalance, bankName);

            Console.WriteLine(threeuple1.ToString());
            Console.WriteLine(threeuple2.ToString());
            Console.WriteLine(threeuple3.ToString());



        }
    }
}
