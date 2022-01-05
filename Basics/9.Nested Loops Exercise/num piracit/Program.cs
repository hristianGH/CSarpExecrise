using System;

namespace num_piracit
{
    class Program
    {
        static void Main(string[] args)
        {
            int imput = int.Parse(Console.ReadLine());
            int num = 1;
            int height = 0;
            int width = 0;
            while (height<imput)
            {
                height++;
                while (width<height)
                {
                    Console.Write(num + " ");
                    num++;
                    width++;
                }
                Console.WriteLine();
            }

        }
    }
}
