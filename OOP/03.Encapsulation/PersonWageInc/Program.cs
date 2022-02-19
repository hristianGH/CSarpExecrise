using System;
using System.Linq;

namespace PersonWageInc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length > 2)
                {
                    people[i] = new Person(input[0] + " " + input[1], int.Parse(input[2]), double.Parse(input[3]));
                }

            }
            double incr = double.Parse(Console.ReadLine());
            foreach (var item in people)
            {
                item.WageInc(incr);
                Console.WriteLine(item);
            }
        }
    }
}
