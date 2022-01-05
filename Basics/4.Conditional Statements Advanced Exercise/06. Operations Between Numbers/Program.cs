using System;
using System.Threading;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = 0.00;
            string sym = Console.ReadLine();
            string evenOrodd = "";
              
            //
            switch (sym)
            {
                case "+":
                    result = (num1 + num2);
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    break;

                     case "-":
                    result = (num1 - num2);
                    if (result % 2 == 0)
                        {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    break;

                     case "*":
                    result = (num1 * num2);
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }

                    break;
             
                   case "/":
                  result = num1 / num2;
                  if (num2 != 0)
                  { Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}"); 
                  }
                  else
                  {
                      Console.WriteLine($"Cannot divide {num1} by zero");
                  }
                  Math.Round(result, 2);
                  break;
              case "%":
                  result = num1 % num2;
                  break;
            }

                 Console.WriteLine(result);
        }
    }
}
