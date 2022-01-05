using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int numOne = 0; numOne <= n; numOne++)
            {
                
                for (int numTwo = 0; numTwo <= n; numTwo++)
                {
                    
                    for (int numTree = 0; numTree <= n; numTree++)
                    {
                        sum = numOne + numTwo + numTree;
                        if (sum == n )
                        {
                            counter++;
                        }

                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
