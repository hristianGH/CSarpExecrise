using System;
using System.Collections.Generic;

namespace _1.DefinePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> family = new List<Person>();
            for (int i = 0; i < n; i++)
            {

                family.Add(AddMember(Console.ReadLine().Split()));
            }
                
            
        }

        private static Person AddMember(string[] input)
        {
            int age = int.Parse(input[1]);
            Person member = new Person(age, input[0]);
            return member;
        }
        private static void GetOldest(List<Person> family)
        {
              family.Sort(delegate (Person age1, Person age2) { return age1.Age.CompareTo(age2.Age);});
              family.Reverse();
              Console.WriteLine($"{family[0].Name} {family[0].Age}");
        }
        private static void PrintVoters(List<Person> family)
        {
            foreach (var item in family)
            {
                if (item.Age > 30)
                {
                    Console.WriteLine($"{family[0].Name} {family[0].Age}");
                }
            }
        }
    }

}
class Person
{

    public Person()
    {
        Age = 1;
        Name = "No name";
    }
    public Person(int age) : this()
    {
        Age = age;
    }
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
    public int Age { get; set; }
    public string Name { get; set; }
}

