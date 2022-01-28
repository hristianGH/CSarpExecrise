using System;
using System.Linq;


namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = input.Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray();
            int[] arrCopy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
            }
            string inputCommand = "";
            while (inputCommand != "end")
            {
                inputCommand = Console.ReadLine();
                string[] commandToArr = inputCommand.Split();
                int commandNumTheSecond = 0;
                int commandNum = 0;
                switch (commandToArr[0])
                {
                    case "swap":
                        commandNum = int.Parse(commandToArr[1]);
                          commandNumTheSecond = int.Parse(commandToArr[2]);
                        arr[commandNum] = arrCopy[commandNumTheSecond];
                        arr[commandNumTheSecond] = arrCopy[commandNum];

                        for (int i = 0; i < arr.Length; i++)
                        {
                            arrCopy[i] = arr[i];
                        }

                        break;
                    case "multiply":
                        commandNumTheSecond = int.Parse(commandToArr[2]);
                        commandNum = int.Parse(commandToArr[1]);
                        arr[commandNum] *= arrCopy[commandNumTheSecond];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arrCopy[i] = arr[i];
                        }
                        break;
                    case "decrease":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i]--;
                        }
                        break;
                }
            }
                Console.WriteLine(string.Join(", ", arr));
        }
    }

}