using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)

        {
            int age = int.Parse(Console.ReadLine());

            string gender = Console.ReadLine();
             if (gender == "f")
            {
                if (age <=16)
                {
                    Console.WriteLine("Miss");
                }
                else
                    Console.WriteLine("Ms.");
            }

            else if (gender=="m")

            {
                if (age <=16)
                {
                    Console.WriteLine("Master");
                }
                else

                    Console.WriteLine("Mr.");
                    
            }
        }
    }
}
