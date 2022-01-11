using System;
using System.Linq;

namespace _07.Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imput = Console.ReadLine().Split();
            int counterL = 0;
            string numL = "";
            for (int i = 0; i < imput.Length; i++)
            {
                int counter = 1;
                string currentNum = imput[i];
                for (int j = i+1; j < imput.Length; j++)
                {
                    if (currentNum==imput[j])
                    {
                        counter++;
                    }
                    else if (currentNum != imput[j])
                    {
                        break;
                    }
                    if (counter>counterL)
                    {
                        numL = currentNum;
                        counterL = counter;
                    }
                }
            }
            for (int i = 0; i < counterL; i++)
            {
                Console.Write(numL + " ");
            }
        } 
    }
}
