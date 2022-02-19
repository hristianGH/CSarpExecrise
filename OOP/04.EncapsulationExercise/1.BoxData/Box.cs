using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BoxData
{
    class Box
    {
        public Box(double length, double width, double height)
        {
            if (length < 0)
            {
                Console.WriteLine("Length cannot be zero or negative");
            }
            else if (width < 0)
            {
                Console.WriteLine("Width cannot be zero or negative");
            }
            else if (height < 0)
            {
                Console.WriteLine("Height cannot be zero or negative");
            }
            else
            {
                X = width;
                Y = height;
                Z = length;
                IsOk = true;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public bool IsOk = false;
        public double SurfaceArea()
        {
            //2xy + 2yz + 2xz
            double sum = 2 * (X * Y + Y * Z + Z * X);
            return sum;
        }
        public double LateralSurface()
        {
            double sum = 2 * (X * Y + Y * Z);
            return sum;
        }
        public double Volume()
        {
            double sum = X * Y * Z;
            return sum;
        }
    }
}
//Volume = lwh
//Lateral Surface Area = 2lh + 2wh
//Surface Area = 2lw + 2lh + 2wh