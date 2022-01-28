using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = "";
            int counter = 1;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                password += name[i];
            }
                string input = Console.ReadLine();
            while (input != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                if (counter>4)
                {
                    Console.WriteLine($"User {name} blocked!");
                    break;
                }
                counter++;
            }
                if (input==password)
                {
                    Console.WriteLine($"User {name} logged in.");
                }

        }
    }
}
 
