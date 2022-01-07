using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int space = int.Parse(Console.ReadLine());
            int takes = people / space;
            int leftBehing = people - takes * space;
            if (space >= people)
            {
                Console.WriteLine("All the persons fit inside in the elevator. Only one course is needed.");
                Environment.Exit(0);
             }
            if (takes * space == people)
            {
                Console.WriteLine($"{takes} courses * {space} people");
            }
            else if (takes * space != people)
            {
                Console.WriteLine($"{takes} courses * {space} people");
                Console.WriteLine($"+ 1 course * {leftBehing} persons");
            }
            

        }
    }
}
