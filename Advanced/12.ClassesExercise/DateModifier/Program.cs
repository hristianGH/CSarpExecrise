using System;

namespace _2.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int year = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int day = int.Parse(input[2]);
            DateTime dateOne = new DateTime(year, month, day);
               input = Console.ReadLine().Split();
              year = int.Parse(input[0]);
              month = int.Parse(input[1]);
             day = int.Parse(input[2]);
            DateTime dateTwo = new DateTime(year, month, day);
            Console.WriteLine(Math.Abs((dateTwo-dateOne).Days));

        }
    }
}
