using System;
using System.Globalization;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            string imputStop = Console.ReadLine();
            while (imputStop!="Stop")
            {
                Environment.Exit(0);

            }
            Console.WriteLine(imputStop);



        }


    }
}
