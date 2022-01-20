using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(x => x != string.Empty || x != null).ToArray();
            List<Info> book = new List<Info>();
            while (input[0] != "end")
            {
                Info contact = new Info();
                contact.FirstName = input[0];
                contact.LastName = input[1];
                contact.Age = input[2];
                contact.City = input[3];
                book.Add(contact);
                input = Console.ReadLine().Split().Where(x => x != string.Empty || x != null).ToArray();
            }
            for (int i = 0; i < book.Count; i++)
            {
                for (int j = i + 1; j < book.Count; j++)
                {
                    if (book[i].FirstName == book[j].FirstName && book[i].LastName == book[j].LastName)
                    {
                        
                        book.RemoveAt(i);
                        i--;
                    }
                }
            }
            string city = Console.ReadLine();
            List<Info> bookFilthered = book.Where(x => x.City == city).ToList();
            foreach (var item in bookFilthered)
            {
                Name(item.FirstName, item.LastName, item.Age);
            }
        }

        private static void Name(string firstName, string lastName, string age)
        {
            Console.WriteLine($"{firstName} {lastName} is {age} years old.");

        }
    }
    class Info
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

    }

}
