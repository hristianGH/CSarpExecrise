using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arrOfNumbers = input.Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
            int[] arrOfNumbersCopy = new int[arrOfNumbers.Length];
             int counter = int.MaxValue;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                arrOfNumbersCopy[i] = arrOfNumbers[i];
            }
            string command = "";
            while (command != "End")
            {
                command = Console.ReadLine();
                string[] commandToArr = command.Split().Select(str => str.Trim()).ToArray();
                switch (commandToArr[0])
                {
                    case "exchange":
                        int commandNum = int.Parse(commandToArr[1]);
                        ArrayExchange(arrOfNumbersCopy, arrOfNumbers, commandNum);
                        break;
                    case "max":
                        MaximumEvenOddNum(arrOfNumbers, commandToArr);
                        break;
                    case "min":
                        for (int i = 0; i < arrOfNumbers.Length; i++)
                        {
                            if (commandToArr[1] == "even")
                            {
                                if (arrOfNumbers[i] % 2 == 0 && arrOfNumbers[i] < counter)
                                {
                                    counter = i;
                                }
                            }
                            else if (commandToArr[1] == "odd")
                            {
                                if (arrOfNumbers[i] % 2 != 0 && arrOfNumbers[i] < counter)
                                {
                                    counter = i;
                                }
                            }
                        }
                        Console.WriteLine(counter
                            );
                        break;
                }


            }


        }
        private static void ArrayExchange(int[] arrOfNumbersCopy, int[] arrOfNumbers, int commandNum)
        {
            if (commandNum > arrOfNumbers.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int counter = 0;
                for (int i = commandNum; i < arrOfNumbers.Length; i++)
                {
                    arrOfNumbers[i] = arrOfNumbersCopy[counter];
                    counter++;
                }

                for (int j = 0; j < commandNum; j++)
                {
                    arrOfNumbers[j] = arrOfNumbersCopy[counter];
                    counter++;
                }
            }


        }

        private static void MaximumEvenOddNum(int[] arrOfNumbers, string[] commandToArr)
        {
            int counter = int.MinValue + 1;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (commandToArr[1] == "even")
                {
                    if (arrOfNumbers[i] % 2 == 0 && arrOfNumbers[i] > counter)
                    {
                        counter = i;
                    }
                }
                else if (commandToArr[1] == "odd")
                {
                    if (arrOfNumbers[i] % 2 != 0 && arrOfNumbers[i] > counter)
                    {
                        counter = i;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
