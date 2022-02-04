using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Trafic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "green")
                {
                    if (cars.Count < n)
                    {
                        for (int i = 0; i < cars.Count - 1; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }

                    }
                    else
                    {

                        for (int i = 0; i < n; i++)
                        {

                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{ counter} cars passed the crossroads.");
        }
    }
}
