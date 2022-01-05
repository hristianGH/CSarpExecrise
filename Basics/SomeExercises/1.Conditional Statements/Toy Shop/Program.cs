using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double talkingDoll = 3.00;
            double stuffedTeddy = 4.10;
            double toyMinion = 8.20;
            double toyTruck = 2.00;
            
            //
            double vacantionPrice = double.Parse(Console.ReadLine());
            int numPuzzle = int.Parse(Console.ReadLine());
            int numTalkingDoll = int.Parse(Console.ReadLine());
            int numStuffedTeddy = int.Parse(Console.ReadLine());
            int numToyMinion = int.Parse(Console.ReadLine());
            int numToyTruck = int.Parse(Console.ReadLine());
            //
            //
            double sumPuzzle = puzzle * numPuzzle;
            double sumTalkingDoll = talkingDoll * numTalkingDoll;
            double sumStuffedTeddy = stuffedTeddy * numStuffedTeddy;
            double sumToyMinion = toyMinion * numToyMinion;
            double sumToyTruck = toyTruck * numToyTruck;
            //
            double priceAllToys = sumPuzzle + sumTalkingDoll + sumStuffedTeddy + sumToyMinion + sumToyTruck;
            //
            //
            int numOfToys = numPuzzle + numStuffedTeddy + numTalkingDoll + numToyMinion + numToyTruck;
            
           
            //
         
        if (numOfToys >= 50 )
       {
           priceAllToys *= 0.75;
       }
         
        double Rent = (priceAllToys * 0.10);
         
           double winnings = priceAllToys - Rent;
          
         
          if (winnings >=vacantionPrice)
          {
              Console.WriteLine($"Yes! {winnings - vacantionPrice:F2} lv left.");
          }
          else
              Console.WriteLine($"Not enough money! {vacantionPrice - winnings:F2} lv needed.");
        }
    }
}
