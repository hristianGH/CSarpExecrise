using System;

namespace _01.Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte employeeOne = sbyte.Parse(Console.ReadLine());
            sbyte employeeTwo = sbyte.Parse(Console.ReadLine());
            sbyte employeeThree = sbyte.Parse(Console.ReadLine());
            int combinedPower =  employeeOne+   employeeTwo+  employeeThree ;

            int students = int.Parse(Console.ReadLine());
            int hoursPassed = 0;
             
            while (students>0)
            {
                students = students - combinedPower;
                hoursPassed++;
                if (hoursPassed%4==0)
                {
                    hoursPassed++;
                }
            }
            Console.WriteLine($"Time needed: {hoursPassed}h.");
        }
    }
}
