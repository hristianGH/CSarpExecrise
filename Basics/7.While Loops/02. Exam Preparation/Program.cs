using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumBadGrade = int.Parse(Console.ReadLine());
            int numProblems = 0;
            int numBadGrade = 1;
            double avgGrade = 0.00;
            string lastproblem = "";

            while (true)
            {
             string nameExercice = Console.ReadLine();
                if (nameExercice=="Enough")
                {
                    break;
                }
                   int grade = int.Parse(Console.ReadLine());
                if (grade<4)
                {
                    numBadGrade++;
                }
                if (numBadGrade==maxNumBadGrade)
                {
                    Console.WriteLine($"You need a break, {numBadGrade} poor grades.");
                    Environment.Exit(0);
                    break;
                }
                avgGrade += grade;
                lastproblem = nameExercice;
                numProblems++;
            }
            avgGrade /= numProblems;
            Console.WriteLine($"Average score: {avgGrade:F2}");
            Console.WriteLine($"Number of problems: {numProblems}");
            Console.WriteLine($"Last problem: {lastproblem}");
        }
    }
}
