using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Students newStudent = new Students(firstName, lastName, grade) { };
                students.Add(newStudent);
            }
            students = students.OrderBy(x => x.Grade).Reverse().ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Students
    {
        public Students(string a, string b, double c)
        {
            Name = a + " " + b;
            Grade = c;
        }
        public double Grade { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Grade:f2}"; 
        }
    }
}
