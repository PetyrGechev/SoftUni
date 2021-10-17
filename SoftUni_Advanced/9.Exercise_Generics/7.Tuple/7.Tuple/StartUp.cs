using System;

namespace _7.Tuple
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
            //{name} {liters of beer}
            string name = secondLine[0];
            double litersOfbeer = double.Parse(secondLine[1]);
            //{integer} {double}
            int integer = int.Parse(thirdLine[0]);
            double doubleNum = double.Parse(thirdLine[1]);

            var tuple1 = new Tuple<string, string>(fullName,adress);
            var tuple2 = new Tuple<string, double>(name,litersOfbeer);
            var tuple3 = new Tuple<int, double>(integer, doubleNum);
            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());

        }
    }
}
