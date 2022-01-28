using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int familyMembers = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < familyMembers; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestPerson());
        }
    }

    class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }

    class Family
    {
        public Family()
        {
            this.family = new List<Person>();
        }
        public List<Person> family { get; set; }

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }
         
        public Person GetOldestPerson()
        {
            Person oldest = this.family.OrderByDescending(n => n.Age).First();

            return oldest;
        }
    }
}
