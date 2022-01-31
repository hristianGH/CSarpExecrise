using System;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            sum = StringConverter(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static int StringConverter(string v1, string v2)
        {
            int sum = 0;
            int v1num = 0;
            int v2num = 0;
            if (v1.Length > v2.Length)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    v1num = v1[i];
                    v2num = v2[i];
                    sum += v1num * v2num;
                }

                if (v1.Length != v2.Length)
                {

                    for (int i = v2.Length; i < v1.Length; i++)
                    {
                        v1num = v1[i];
                        sum += v1num;
                    }
                }

            }
            else
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    v1num = v1[i];
                    v2num = v2[i];
                    sum += v1num * v2num;
                }
                if (v1.Length != v2.Length)
                {
                    for (int i = v1.Length; i < v2.Length; i++)
                    {
                        v2num = v2[i];
                        sum += v2num;
                    }
                }
            }
            return sum;
        }
    }
}
