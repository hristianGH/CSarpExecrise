using System;
using System.Linq;

namespace _11._2_ArrayManipolator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arrOfNumbers = input.Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
            int[] arrOfNumbersCopy = new int[arrOfNumbers.Length];
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                arrOfNumbersCopy[i] = arrOfNumbers[i];
            }
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] commandToArr = command.Split().Select(str => str.Trim()).ToArray();
                int commandNum = 0; ;

                switch (commandToArr[0])
                {
                    case "exchange":
                        commandNum = int.Parse(commandToArr[1]);
                        ArrayExchange(arrOfNumbersCopy, arrOfNumbers, commandNum);
                        break;
                    case "max":
                        MaximumEvenOddNum(arrOfNumbers, commandToArr);
                        break;
                    case "min":
                        MinimumEvenOddNum(arrOfNumbers, commandToArr);
                        break;
                    case "first":
                        int[] first = new int[commandNum];
                        FirstEvenOddNum(commandToArr, arrOfNumbers, first);
                        break;
                    case "last":
                        first = new int[commandNum];
                        LastEnvenOddNum(commandToArr, arrOfNumbers, first);
                        break;

                }


            }
        }




        private static void LastEnvenOddNum(string[] commandToArr, int[] arrOfNumbers, int[] first)
        {
            int counter = 0;

            int commandNum = int.Parse(commandToArr[1]);
            first = new int[commandNum];
            if (commandToArr[2] == "even")
            {

                for (int i = arrOfNumbers.Length - 1; i >= 0; i--)
                {
                    if (arrOfNumbers[i] % 2 == 0)
                    {
                        first[counter] = arrOfNumbers[i];
                        counter++;
                    }
                    if (counter == commandNum)
                    {
                        break;
                    }

                }
                int[] withoutZero = (first).Where(i => i != 0).ToArray();
                Console.WriteLine($"[{String.Join(",", withoutZero)}]");
            }

            else if (commandToArr[2] == "odd")
            {
                for (int i = arrOfNumbers.Length - 1; i >= 0; i--)
                {
                    if (arrOfNumbers[i] % 2 != 0)
                    {
                        first[counter] = arrOfNumbers[i];
                        counter++;
                    }
                    if (counter == commandNum)
                    {
                        break;
                    }
                }
                int[] withoutZero = (first).Where(i => i != 0).ToArray();

                Console.WriteLine($"[{String.Join(",", withoutZero)}]");
            }
        }

        private static void FirstEvenOddNum(string[] commandToArr, int[] arrOfNumbers, int[] first)

        {
            int counter = 0;
            int commandNum = int.Parse(commandToArr[1]);
            first = new int[commandNum];

            if (commandToArr[2] == "even")
            {

                for (int i = 0; i < arrOfNumbers.Length; i++)
                {
                    if (arrOfNumbers[i] % 2 == 0)
                    {
                        first[counter] = arrOfNumbers[i];
                        counter++;
                    }
                    if (counter == commandNum)
                    {
                        break;
                    }

                }
                int[] withoutZero = (first).Where(i => i != 0).ToArray();
                Console.WriteLine($"[{String.Join(",", withoutZero)}]");

            }

            else if (commandToArr[2] == "odd")
            {
                for (int i = 0; i < arrOfNumbers.Length; i++)
                {
                    if (arrOfNumbers[i] % 2 != 0)
                    {
                        first[counter] = arrOfNumbers[i];
                        counter++;
                    }
                    if (counter == commandNum)
                    {
                        break;
                    }
                }
                int[] withoutZero = (first).Where(i => i != 0).ToArray();

                Console.WriteLine($"[{String.Join(",", withoutZero)}]");
            }

        }

        private static void MinimumEvenOddNum(int[] arrOfNumbers, string[] commandToArr)
        {
            int chek = int.MaxValue;
            int counter = 0;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (commandToArr[1] == "even")
                {
                    if (arrOfNumbers[i] % 2 == 0 && arrOfNumbers[i] < chek)
                    {
                        counter = i;
                    }
                }
                else if (commandToArr[1] == "odd")
                {
                    if (arrOfNumbers[i] % 2 != 0 && arrOfNumbers[i] < chek)
                    {
                        counter = i;
                    }
                }
            }
            Console.WriteLine(counter);

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
            Console.WriteLine($"[{String.Join(",", arrOfNumbers)}]");


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
       