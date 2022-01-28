using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                   for (int k = 0; k < n; k++)
                   {
                        char letterFirst = (char)(97 + i);
                        char letterSecond = (char)(97 + y);
                        char letterThird = (char)(97 + k);
                        Console.WriteLine($"{letterFirst}{letterSecond}{letterThird}");
                        

                    }
                  
                } 
               
            }
        }
    }
}
