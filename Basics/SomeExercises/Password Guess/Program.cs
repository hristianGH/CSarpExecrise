using System;

namespace _05._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass1 = Console.ReadLine();
           // string pass = "s3cr3t!P @ssw0rd";
            if (pass1 == "s3cr3t!P @ssw0rd") 
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}
