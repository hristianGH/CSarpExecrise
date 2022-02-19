using System;
using System.Linq;

namespace NameAgeSort
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
                people[i] = new Person(input[0] + " " + input[1], int.Parse(input[2]));
            }
            
            foreach (var item in people.OrderBy(x=>x.Name).ThenBy(x=>x.Name))
            {
                 
                Console.WriteLine(item);
            }
        }
    }
}
