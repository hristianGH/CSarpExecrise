using System;

namespace TestCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            double radius;
            double thickness = 0.4;
            char symbol = '*';
            do
            {
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("radius have to be positive number");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rIn = radius - thickness,
                rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.4)
                {
                    time++;
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
                Console.WriteLine( );
            }
        }
    }
}
