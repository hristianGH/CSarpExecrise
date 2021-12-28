using System;

namespace PersonInfoFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            var fName = Console.ReadLine();
            Console.WriteLine("Enter Lirst name");
            var lName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Town");
            var town = Console.ReadLine();
            Console.WriteLine($"{fName} {lName} from {town} is {age} years old");

        }
    }
}
