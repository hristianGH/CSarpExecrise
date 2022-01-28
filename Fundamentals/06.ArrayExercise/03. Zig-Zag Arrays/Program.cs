using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstStorage = "";
            string secondStorage = "";
            int counter = 0;


            while (counter < n)
            {
                string first = Console.ReadLine();
                firstStorage = firstStorage + " " + first;
                counter++;
                Console.WriteLine(counter);
                // if (counter%2==0)
                // {
                //
                // }
                // string[] splitFirst = first.Split();
                string second = Console.ReadLine();
                secondStorage = secondStorage + " " + second;
                //string[] splitSecond = second.Split();

                counter++;
                Console.WriteLine(counter);
            }
            Console.WriteLine(firstStorage);
            Console.WriteLine(secondStorage);
        }
    }
}
