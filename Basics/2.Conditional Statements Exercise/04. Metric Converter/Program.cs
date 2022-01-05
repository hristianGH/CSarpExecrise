using System;
using System.Diagnostics.Contracts;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string takeIn = Console.ReadLine();
            string convert = Console.ReadLine();
            //
            if (takeIn=="mm" )
            {
                if (convert =="m")
                { 
                    Console.WriteLine($"{number * 0.001:f3}");
                    

                }
                else if (convert =="mm")
                {
                    Console.WriteLine($"{number:f3}");
                }
                else if (convert =="cm")
                {
                    Console.WriteLine($"{number * 0.1}");
                }

            }
            else if (takeIn =="cm")
            {
                if (convert=="m")
                {
                    Console.WriteLine($"{number * 0.01:F3}" );

                }
                else if (convert=="cm")
                {
                    Console.WriteLine($"{number:f3}");

                }
                else if (convert =="mm")
                {
                    Console.WriteLine($"{number*10:f3}");
                }
            }

            else if (takeIn =="m")
            {
                if (convert=="m")
                {
                    Console.WriteLine($"{number*1:f3}");
                }

                else if (convert=="cm")
                {
                    Console.WriteLine($"{number*100:f3}");
                }
                else if (convert=="mm")
                {
                    Console.WriteLine($"{number*1000:f3}");
                }
            }

            
            

        }
    }
}
