using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int numOne = 1; numOne <= 10; numOne++)
            { 
               for (int numTwo = 1; numTwo <= 10; numTwo++)
               {
                    int sum = numOne*numTwo;
                   Console.WriteLine($"{numOne} * {numTwo} = {sum}");
               }
            } 
        }
    }
}
