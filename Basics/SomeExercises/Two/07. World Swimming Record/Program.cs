using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceMetre = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());
            double swimDistance = distanceMetre * timeInSec;
            double waterSlowDown = Math.Floor(distanceMetre / 15) * 12.5;
           
            
          // double waterSlowDown2= distanceMetre * 12.5;
            double sumTime = swimDistance + waterSlowDown;


            
       
       if(recordInSec>sumTime)
       {
           Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
       }
       else
       {
           Console.WriteLine($"No, he failed! He was {sumTime-recordInSec:f2} seconds slower.");
       }
       
       }
    } 
}

