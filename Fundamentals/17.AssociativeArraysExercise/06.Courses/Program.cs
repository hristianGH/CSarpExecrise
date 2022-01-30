using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dicList = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" :", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "end")
            {
                string course = input[0];
                string name = input[1];
                if (dicList.ContainsKey(input[0]))
                {
                    dicList[course].Add(name);
                }
                else
                {
                    dicList.Add(course, new List<string> { name });
                }
                input = Console.ReadLine().Split(" :", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var course in dicList.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var name in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"--{name}");
                }
            }
        }
    }
}
