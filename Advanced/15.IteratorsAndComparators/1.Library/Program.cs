using System;
using System.Collections.Generic;

namespace _1.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
              var library = new BookLibrary<Book>(bookOne,bookTwo,bookThree);
            foreach (var item in library)
            {
                Console.WriteLine(item.ToString());
            }
            Array.Sort(library.Items, (x, y) => x.CompareTo(y));
            foreach (var item in library)
            {
                Console.WriteLine(item.ToString());
            }
             
        }
    }
}

