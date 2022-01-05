using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int stepsCounter = 0;
            while (true)
            {
                string steps = Console.ReadLine();
                if (steps=="Going home")
                {
                    Console.WriteLine("Going home");
                    break;
                }
                if (stepsCounter>10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsCounter-10000} over the goal!");
                        break;
                }
                   int steps2=int.Parse(steps);
                stepsCounter += steps2;

            }



        }
    }
}
