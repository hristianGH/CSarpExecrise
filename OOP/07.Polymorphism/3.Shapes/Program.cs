using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3, 4);
            Circle circle = new Circle(3);
            Console.WriteLine(rec.Draw());
            Console.WriteLine(circle.Draw());
        }
    }
}
