using System;

namespace _3._Elevator_the_actual
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int space = int.Parse(Console.ReadLine());
            int courses = 0;
            while (people>0)
            {
                people = people - space;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
