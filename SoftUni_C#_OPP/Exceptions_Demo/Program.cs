using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExceptionsDemos
{

    class Program
    {
        static void Main()
        {
            int num = 1;
            for (int i = 0; i < 0; i++)
            {
                num *= 2;
            }

            Console.WriteLine(num);


            var a = 2;
            new int[0].Where(x => a++ != 0);

            Console.OutputEncoding = Encoding.Unicode;
            A();

            IEgnValidator validator = new EgnValidator();
            try
            {
                validator.Validate(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("EGN should not be empty!");
            }
            catch (Exception)
            {

            }

            try
            {
                // TODO: Read from user
                validator.Generate(new DateTime(1907, 1, 1), "Калифорния", false);
            }
            catch (InvalidCityException ex)
            {
                Console.WriteLine("Invalid city:" + ex.CityName);
            }

            Console.WriteLine(ReadInteger() * 10);
            // ReadInteger();
            // int number = int.Parse("милион и едно");


            Console.WriteLine("End of Main()");
        }

        public static void A()
        {
            try
            {
                B();
            }
            catch (Exception ex)
                when (ex is ArgumentNullException || ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("ERROR IN B();");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR IN B(); general");
            }
        }

        public static void B()
        {
            C();
        }

        public static void C()
        {
            throw new Exception("..");
        }

        public static void WriteToFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("test.txt");
                Console.WriteLine(sr.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
            finally
            {
                sr?.Dispose();
            }

            Console.WriteLine();
        }

        public static int ReadInteger()
        {
            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    return int.Parse(line);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Invalid number format ({ex.Message}).");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter number less than " + int.MaxValue);
                }
                finally
                {
                    Console.WriteLine("FINALLY!!!");
                }
            }
        }
    }
}
