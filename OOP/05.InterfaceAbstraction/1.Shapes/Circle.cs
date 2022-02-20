using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Circle : IDrawable
    {
        public Circle(int radi)
        {
            Radius = radi;
        }
        public int Radius { get; set; }

        public void Draw()
        {
            double radius = Radius;
            double thickness = 0.4;
            char symbol = '*';
            double rIn = radius - thickness,
                rOut = radius + thickness;

            Console.WriteLine();


            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.4)
                {
                     
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {

                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
