using System;
using System.Collections;
using System.Collections.Generic;

namespace _5.CountGenericsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double value;
            bool IsItINT = double.TryParse(input, out value);
            if (IsItINT == true)
            {

                Box<double> boxDouble = new Box<double>(n);
                boxDouble.Value[0] = double.Parse(input);
                for (int i = 1; i < n; i++)
                {
                    boxDouble.Value[i] = double.Parse(Console.ReadLine());
                }
                double comparison = double.Parse(Console.ReadLine());
                foreach (var item in boxDouble.Value)
                {
                    if (comparison.CompareTo(item) < 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                Box<string> boxText = new Box<string>(n);
                boxText.Value[0] = input;
                for (int i = 1; i < n; i++)
                {
                    boxText.Value[i] = Console.ReadLine();
                }
                string comparison = Console.ReadLine();
                foreach (var item in boxText.Value)
                {
                    if (comparison.CompareTo(item)<0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }

}

class Box<T> 
{
    public Box(int n)
    {
        Value = new T[n];
    }
    public T[] Value { get; set; }

     
    public override string ToString()
    {
        return $"{Value.GetType()}:";
    }
}

