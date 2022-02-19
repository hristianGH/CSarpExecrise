using System;

namespace _1.BoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);
            if (box.IsOk == true)
            {
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurface():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
        }
    }
}

//length, width and height