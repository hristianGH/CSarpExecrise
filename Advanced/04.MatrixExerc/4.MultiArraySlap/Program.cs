using System;

namespace _4.MultiArraySlap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] holder = new string[2];
            string[] xAndY = Console.ReadLine().Split();
            string[][] matrix = new string[int.Parse(xAndY[0])][];
            for (int y = 0; y < int.Parse(xAndY[0]); y++)
            {
                matrix[y] = Console.ReadLine().Split();
            }
            string[] input = Console.ReadLine().Split();
            //x y x y
            while (input[0] != "END")
            {

                if (input.Length == 5)
                {

                    if (input[0] == "swap" && input[1] != null && input[2] != null && input[3] != null && input[4] != null)
                    {
                        int oneY = int.Parse(input[1]);
                        int oneX = int.Parse(input[2]);
                        int twoY = int.Parse(input[3]);
                        int twoX = int.Parse(input[4]);

                        if (oneY <= matrix.GetLength(0) && oneX < matrix[oneY].Length && twoY <= matrix.GetLength(0) && twoX < matrix[twoY].Length)
                        {
                            holder[0] = matrix[oneY][oneX];
                            holder[1] = matrix[twoY][twoX];
                            matrix[oneY][oneX] = holder[1];
                            matrix[twoY][twoX] = holder[0];


                            foreach (string[] item in matrix)
                            {
                                Console.WriteLine(string.Join(" ", item));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine().Split();

            }
        }
       static void Checker(string[] input , string[][] matrix)
        {

        }
    }
}
