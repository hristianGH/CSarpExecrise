using System;


namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int levelGrades = 0;
            int repeatedClasses = 0;
            double sumGrades = 0;
            while (levelGrades<12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade<4.00)
                {
                    repeatedClasses++;
                    if (repeatedClasses==2)
                    {
                        Console.WriteLine($"{name} has been excluded at {levelGrades} grade");
                        Environment.Exit(0);
                    }
                }
                levelGrades++;
                sumGrades += grade;
            }
            sumGrades =sumGrades / levelGrades;
            
            Console.WriteLine($"{name} graduated. Average grade: {sumGrades:F2}");
        }
    }
}
