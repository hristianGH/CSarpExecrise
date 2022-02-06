using System;
using System.Collections.Generic;

namespace _2.Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            double rounder = 0.00;
            Dictionary<string, List<double>> studentGrade = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (studentGrade.ContainsKey(input[0]))
                {
                    studentGrade[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    studentGrade.Add(input[0], new List<double>());
                    studentGrade[input[0]].Add(double.Parse(input[1]));
                }
            }
           
            foreach (var item in studentGrade)
            {
                rounder = 0;
                Console.Write($"{item.Key}-> ");
                foreach (double grades in item.Value)
                {
                    rounder += grades;
                    Console.Write($"{grades:f2} ");
                }
                Console.Write($"(avg:{rounder/item.Value.Count:f2})");
                Console.WriteLine();
            }
        }
    }
}
