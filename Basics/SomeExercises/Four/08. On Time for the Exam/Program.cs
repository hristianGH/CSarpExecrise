using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hEnter = int.Parse(Console.ReadLine());
            int mEnter = int.Parse(Console.ReadLine());
            int examMinutes = hExam * 60 + mExam;
            int arriveMinutes = hEnter * 60 + mEnter;
            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                int late = arriveMinutes - examMinutes;
                if (late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int lateH = late / 60;
                    int lateM = late % 60;
                    Console.WriteLine($"{lateH}:{lateM:D2} hours after the start");
                }
            }
            else if (examMinutes == arriveMinutes || (examMinutes - arriveMinutes) <= 30)
            {
                Console.WriteLine("On time");
                if (examMinutes - arriveMinutes <= 30)
                {
                    Console.WriteLine($"{examMinutes - arriveMinutes} minutes before the start");
                }
            }
            else if (examMinutes - arriveMinutes > 30)
            {
                Console.WriteLine("Early");
                int early = examMinutes - arriveMinutes;
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
                else
                {
                    int hEarly = early / 60;
                    int mEarly = early % 60;
                    Console.WriteLine($"{hEarly}:{mEarly:D2} hours before the start");
                }
            }
        }
    }
}
