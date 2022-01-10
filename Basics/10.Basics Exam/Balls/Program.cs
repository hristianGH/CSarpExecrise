using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int other = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string ball = Console.ReadLine().ToLower();

                if (ball=="red")
                {
                    red++;
                    points += 5;
                }
                else if (ball == "orange")
                {
                    orange++;
                    points += 10;
                }
                else if (ball == "yellow")
                {
                    yellow++;
                    points += 15;

                }
                else if (ball == "white")
                {
                    white++;
                    points += 20;

                }
                else if (ball == "black")
                {
                    black++;
                    points = points / 2;

                }
                else
                {
                    other++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");


        }
    }
}
