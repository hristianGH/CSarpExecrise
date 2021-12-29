using System;

namespace Architect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int projectCount =0;
            int timeNeeded=3;
            Console.WriteLine("Enter architect name");
            name = Console.ReadLine();
            Console.WriteLine("Enter project count");
            projectCount = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name} will need {projectCount*timeNeeded} to complete {projectCount} projects");
        }
    }
}
