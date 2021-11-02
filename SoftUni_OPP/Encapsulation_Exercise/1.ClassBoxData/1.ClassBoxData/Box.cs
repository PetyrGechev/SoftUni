using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _1.ClassBoxData
{
    public class Box
    {


        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

      

        //"{propertyName} cannot be zero or negative."
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                height = value;


            }

        }


        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;

            }
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;

            }
        }

        public string  SurfaceArea()
        {
            double result = (2 * length * width) + (2 * length * height) + (2 * width * height);
            // 2lw + 2lh + 2wh
            return $"Surface Area - {result:f2}";
        }
        public string LateralSurfaceArea()
        {

            double result =  (2 * length * height) + (2 * width * height);
            // 2lh + 2wh
            return $"Lateral Surface Area - {result:f2}"; ;
        }
        public string Volume()
        {
            double result = length*height*width;
            // lwh
            return $"Volume - {result:f2}";
        }

        public void CheckArgument(string argument, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{argument} cannot be zero or negative.");
            }

        }
    }
}
