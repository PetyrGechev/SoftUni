using System;

namespace _1.ClassBoxData
{
    class Program
    {
        public static void Main(string[] args)
        {


            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                //Surface Area - 52.00
                // Lateral Surface Area - 40.00
                //Volume - 24.00
                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralSurfaceArea());
                Console.WriteLine(box.Volume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }

        }
    }
}
