using System;

namespace _5.CommandsGame
{
    class Program
    {
        public delegate void Command(string[] nu, string c);
        static void Main(string[] args)
        {
            string[] arrInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Command command = (arr, com) =>
              {
                  switch (com)
                  {
                      case "add":
                          for (int i = 0; i < arr.Length; i++)
                          {
                              int number = int.Parse(arr[i]);
                              number++;
                              arr[i] = number.ToString();
                          }
                          break;
                      case "multiply":
                          for (int i = 0; i < arr.Length; i++)
                          {
                              int number = int.Parse(arr[i]);
                              number*=2;
                              arr[i] = number.ToString();
                          }
                          break;
                      case "subtract":
                          for (int i = 0; i < arr.Length; i++)
                          {
                              int number = int.Parse(arr[i]);
                              number --;
                              arr[i] = number.ToString();
                          }
                          break;
                      case "print":
                          Console.WriteLine(string.Join(" ",arr));
                          break;
                      default:
                          break;
                  };
                 
              };
            string input = Console.ReadLine();
            while (input!="end")
            {
                command(arrInput, input);
                input = Console.ReadLine();
            }
        }
    }
}
