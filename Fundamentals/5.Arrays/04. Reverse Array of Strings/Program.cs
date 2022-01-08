using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
             string imput = Console.ReadLine();
            string[] imputSepperator = imput.Split(' ');
            int imputLenght = imputSepperator.Length;
            for (int i =imputLenght - 1 ; i >= 0; i--)
            {
                Console.Write($"{imputSepperator[i]} ");
            }
        }
    }
}
