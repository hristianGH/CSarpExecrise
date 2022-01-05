using System;

public class Program
{
    public static void Main()
    {
        string stop = (Console.ReadLine());

        int maxNumber = int.MinValue;

        while (stop != "Stop")
        {
            int currentNumber = int.Parse(stop);

            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }

        }
        Console.WriteLine(maxNumber);

    }
}