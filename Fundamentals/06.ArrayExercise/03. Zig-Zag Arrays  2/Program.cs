using System;

namespace _03._Zig_Zag_Arrays__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstStorage = "";
            string secondStorage = "";
            for (int i =1; i <= n; i++)
            {
                string imput = Console.ReadLine();
                string[] spliter = imput.Split();
                if (i%2==0)
                {
                    firstStorage = firstStorage + " " + spliter[1];
                    secondStorage = secondStorage + " " + spliter[0];

                }
                else
                {
                firstStorage = firstStorage + " " + spliter[0];
                secondStorage = secondStorage + " " + spliter[1];

                }

            }
            Console.WriteLine(firstStorage);
            Console.WriteLine(secondStorage);

        }
    }
}
