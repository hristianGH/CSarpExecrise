using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVacation = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int daysCounter = 1;
            int spendCounter = 0;
            int saveCounter = 0;
            while (true)
            {
                string spendOrSave = Console.ReadLine();
                double moneyAdd = double.Parse(Console.ReadLine());
                if (spendOrSave == "save")
                {
                    money += moneyAdd;
                    saveCounter++;
                }

                else if (spendOrSave == "spend")
                {
                    money -= moneyAdd;
                    spendCounter++;
                }
                if (money<0)
                {
                    money = 0;
                }
                if (money >=moneyVacation)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.") ;
                    break;
                }
                if (spendCounter>=5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(spendCounter);
                    break;
                }
                daysCounter++;
            }

        }
    }
}
