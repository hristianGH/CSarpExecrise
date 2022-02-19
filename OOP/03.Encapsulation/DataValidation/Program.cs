using System;
using System.Linq;

namespace DataValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            bool CurrectInput = true;
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0].Length < 3)
                {
                    CurrectInput = false;
                    Console.WriteLine("First name cannot contain fewer than 3 symbols!");
                }
                if (input[1].Length < 3)
                {
                    CurrectInput = false;
                    Console.WriteLine("Last name cannot contain fewer than 3 symbols!");
                }
                if (int.Parse(input[2]) < 0)
                {
                    CurrectInput = false;
                    Console.WriteLine("Age cannot be zero or a negative integer!");
                }
                if (double.Parse(input[3]) < 460)
                {
                    CurrectInput = false;
                    Console.WriteLine("Salary cannot be less than 460 leva!");
                }
                if (CurrectInput == true)
                {
                    people[i] = new Person(input[0] + " " + input[1], int.Parse(input[2]), double.Parse(input[3]));
                }
                CurrectInput = true;
            }
            double incr = double.Parse(Console.ReadLine());
            foreach (var item in people)
            {
                if (item != null)
                {

                    item.WageInc(incr);
                    Console.WriteLine(item);
                }
            }
        }
    }
}
