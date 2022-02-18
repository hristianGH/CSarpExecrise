using System;

namespace _1.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            //string name = "Pesho";
            //int age = 15;
            Person person = new Person();
            if (age>15)
            {
                person = new Person(name, age);
            }
            else
            {
                person = new Child(name, age);
            }
            Console.WriteLine(person);
            Console.WriteLine(person.GetType().Name);
        }
    }
}
