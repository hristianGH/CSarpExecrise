using System;

namespace _5.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = "";
            int mostGoals = 0;
            string playerName = Console.ReadLine();
            while (playerName.ToLower() != "end")
            {
                int countGoals = int.Parse(Console.ReadLine());
                if (countGoals > mostGoals)
                {
                    bestPlayer = playerName;
                    mostGoals = countGoals;
                }
                playerName = Console.ReadLine();

            }
            if (mostGoals>=3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!{Environment.NewLine}He has scored {mostGoals} goals and made a hat-trick !!!");

            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!{Environment.NewLine}He has scored {mostGoals} goals.");

            }
        }
    }
}
