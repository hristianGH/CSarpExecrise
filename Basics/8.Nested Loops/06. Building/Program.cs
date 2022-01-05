using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNum = int.Parse(Console.ReadLine());
            int apartmentPerFloor = int.Parse(Console.ReadLine());
            int floorCounter = floorNum;
            for (int i = 0; i < apartmentPerFloor; i++)
            {
                Console.Write($"L{floorNum}{i} ");
            }
            floorCounter--;
            while (floorCounter > 0)
            {
                Console.WriteLine();
                if (floorCounter%2==0)
                {
                    for (int i = 0; i < apartmentPerFloor; i++)
                    { 
                        Console.Write($"O{floorCounter}{i} ");
                    }
                    floorCounter--;
                }
                else  
                {
                    for (int i = 0; i < apartmentPerFloor; i++)
                    {
                        Console.Write($"A{floorCounter}{i} ");
                    }
                    floorCounter--;
                }
                 
            }
        }
    }
}