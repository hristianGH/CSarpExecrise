using System;

namespace _1.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            rectangle.Draw();
            Circle cir = new Circle(int.Parse(Console.ReadLine()));
            cir.Draw();
        }
    }
}
