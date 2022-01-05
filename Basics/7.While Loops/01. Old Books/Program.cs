using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            int count = 0;

            while (true)
            {
                string bookFound = Console.ReadLine();
                if (bookFound==bookToFind)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                else if (bookFound=="No More Books")
                  {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                  }
               
                count++;
            }

        }
    }
}
