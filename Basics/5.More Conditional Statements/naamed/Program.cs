using System;

public class Program
{
	static double mayOctomberS = 50;
	static double mayOctomberA = 65;
	static double juneSeptS = 75.20;
	static double juneSeptA = 68.70;
	static double julyAugS = 76;
	static double julyAugA = 77;

	public static void Main()
	{
		string month = Console.ReadLine();
		int nights = int.Parse(Console.ReadLine());
		double studio = 0;
		double apartment = 0;

		if (month == "May" || month == "October")
		{
			studio = mayOctomberS * nights;
			apartment = mayOctomberA * nights;
			if (nights > 7 && nights < 14)
			{
				studio = studio - studio * 0.05;
			}
			else if (nights > 14)
			{
				studio = studio - studio * 0.30;
				apartment = apartment - apartment * 0.10;
			}
		}
		else if (month == "June" || month == "September")
		{
			studio = juneSeptS * nights;
			apartment = juneSeptA * nights;
			if (nights > 14)
			{
				apartment = apartment - (apartment * 0.10);
			}
			}
            Console.WriteLine(apartment);
	//	}
	//	else if (month == "July" || month == "August")
	//	{
	//		studio = julyAugS * nights;
	//		apartment = julyAugA * nights;
	//		if (nights > 14)
	//		{
	//			apartment = apartment - (apartment * 0.10);
	//		}
	//	}
	//	Console.WriteLine($"Apartment: {apartment:f2} lv.");
	//	Console.WriteLine($"Studio: {studio:f2} lv.");

	}
}