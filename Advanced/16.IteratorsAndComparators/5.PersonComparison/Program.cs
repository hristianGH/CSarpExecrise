using System;

namespace _5.PersonComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int match = 0;
            string input = Console.ReadLine();
            ListPeople listPeople = new ListPeople();
            listPeople.Add(input.Split());
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input != "END")
                {
                    listPeople.Add(input.Split());

                }
            }
            int num = int.Parse(Console.ReadLine());
            foreach (Person item in listPeople)
            {
                if (listPeople.People[num - 1].CompareTo(item) == 0)
                {
                    match++;
                }
            }
            if (match < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{match} {listPeople.People.Count - match} {listPeople.People.Count}");

            }
        }
    }
}
