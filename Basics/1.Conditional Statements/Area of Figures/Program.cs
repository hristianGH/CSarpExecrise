using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                //double h = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
            else if (type == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(side * h);

            }
            else if (type == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side* Math.PI);
            }
            else if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(side*h/2);
            }
        }
    }
}
