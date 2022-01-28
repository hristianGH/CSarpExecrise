using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            List<People> peoples = new List<People>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split();
                People people = new People(arg[0], arg[1], int.Parse(arg[2]));

                peoples.Add(people);
            }

            peoples = peoples.OrderBy(x => x.Age).ToList();
            foreach (var people in peoples)
            {
                Console.WriteLine(people);
            }
         
        }
    }
    class People
    {
        public People(string name,string iD,int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} with ID: {ID} is {Age} years old.");
            return sb.ToString().TrimEnd(); 
        }
    }
}
