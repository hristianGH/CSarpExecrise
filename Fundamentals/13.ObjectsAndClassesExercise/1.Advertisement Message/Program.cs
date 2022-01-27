using System;
using System.Collections.Generic;
using System.Numerics;


namespace _1.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Messege> construct = new List<Messege>();
            Random rnd = new Random();
            int rolls = int.Parse(Console.ReadLine());
            int[] rndStorage = new int[rolls * 4];

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product.",
                    "Excellent product.",
                    "I always use that product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!",
                    "I feel great!",
                    "Makes miracles. I am happy of the results!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse", "Sofia", "Plovdiv", "Varna" };
            for (int i = 0; i < rndStorage.Length; i++)
            {
                rndStorage[i] = rnd.Next(phrases.Length - 1);

            }
            for (int i = 0; i < rolls; i++)
            {
                Messege text = new Messege()
                {
                    Phrases = phrases[rndStorage[i]],
                    Events = events[rndStorage[i + 1]],
                    Authors=authors[rndStorage[i+2]],
                    Cities=cities[rndStorage[i+3]]
                };
                construct.Add(text);
            }
            foreach (var text in construct)
            {

                Console.WriteLine($"{string.Join(" ", text.Phrases, text.Events)} {(text.Authors)} - {(text.Cities)}  " );
            }
          
        }
    }
    class Messege
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }
    }
}
