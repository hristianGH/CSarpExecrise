using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double money = 0.0;
             if (type=="Premiere")
            {
                money = 12.00;
            }
             else if (type=="Normal")
            {
                money = 7.50;
            }
             else if (type=="Discount")
            {
                money = 5.00;

            }
            double calculations = (rows * colums) * money;
            Console.WriteLine($"{calculations:f2} leva");
        }
    }
}
