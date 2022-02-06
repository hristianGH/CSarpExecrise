using System;
using System.Collections.Generic;
namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string[] arr = Console.ReadLine().Split(", ");
            while (arr[0]!="END")
            {
                if (arr[0]=="IN")
                {
                    cars.Add(arr[1]);
                }
                else
                {
                    cars.Remove(arr[1]);
                }
                arr = Console.ReadLine().Split(", ");
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
