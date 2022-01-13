using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeGrading(grade);
        }

          static void GradeGrading(double grade)
        {
            if (grade>2.99 && grade <3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade < 4.49)
                {
                  Console.WriteLine("Good");
                }
            else if (grade >= 4.50 && grade < 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >=5.50  )
            {
                Console.WriteLine("Exellent");
            }
            else  
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
