using System;
using System.Linq;

namespace _08.ZadachaOsem
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal calc = 0;

            foreach (var item in input)
            {
                char begining = item[0];
                bool IsUpperCase = char.IsUpper(item[0]);
                char ending = item[item.Length - 1];
                string summa = item.Substring(1, item.Length - 2);
                if (IsUpperCase == true)
                {
                    begining = char.ToLower(begining);
                    calc = decimal.Parse(summa) / (begining - 96);
                }
                else
                {
                    
                    calc = decimal.Parse(summa) * (begining - 96);
                }
                IsUpperCase = char.IsUpper(ending);
                if (IsUpperCase == true)
                {
                    ending = char.ToLower(ending);
                    calc -=  (ending - 96);
                }
                else
                {

                  
                    calc +=  (ending - 96);
                }
                sum += calc;
                
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
 

