using System;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imputNumbers = Console.ReadLine().Split();
            int rotationStarter = int.Parse(Console.ReadLine());

            if (rotationStarter>imputNumbers.Length)
            {
                rotationStarter -= imputNumbers.Length;
            }

            for (int i = rotationStarter; i < imputNumbers.Length; i++)
            {
                Console.Write($"{imputNumbers[i]} ");

            }

                for (int y = 0; y < rotationStarter; y++)
                {
                    Console.Write($"{imputNumbers[y]} ");

                }


        }
    }
}
