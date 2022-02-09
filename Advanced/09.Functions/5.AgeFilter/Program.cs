using System;

namespace _5.AgeFilter
{
    public delegate int Age(int age);
    public delegate void PrintVariant(string input, NameAge data);
    class Program
    {

        static void Main(string[] args)
        {
            PrintVariant variant = ( x, data) =>
            {
                if (x == "name")
                {
                    Console.WriteLine(data.Name);
                }

                else if (x == "age")
                {
                    Console.WriteLine(data.Age);
                }
                else if (x == "name age")
                {
                    Console.WriteLine($"{data.Name} - {data.Age}");
                }
            };
            int n = int.Parse(Console.ReadLine());
            NameAge[] nameAge = new NameAge[n];
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ");
                nameAge[i] = new NameAge(data[0], int.Parse(data[1]));
            }

            if (Console.ReadLine() == "older")
            {
                int num = int.Parse(Console.ReadLine());
                string outputInfo = Console.ReadLine();
                foreach (var item in nameAge)
                {
                    if (item.Age >= num)
                    {
                        variant(outputInfo, item);
                    }
                }
            }
            else
            {
                int num = int.Parse(Console.ReadLine());
                string outputInfo = Console.ReadLine();
                foreach (var item in nameAge)
                {
                    if (item.Age < num)
                    {
                        variant(outputInfo, item);

                    }
                }
            }
        }
    }
    public class NameAge
    {
        public NameAge(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
