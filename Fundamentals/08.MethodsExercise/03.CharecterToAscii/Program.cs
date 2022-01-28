using System;

namespace _03.CharecterToAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputChar = Convert.ToChar(Console.ReadLine());
            char inputTheSecond = Convert.ToChar(Console.ReadLine()); ;
            int toAscii = inputChar;
            int toAsciiTheSecondSonOfTheDragonFromTheVillageOfThe = inputTheSecond;
            ToIntegerFromChar(toAscii, toAsciiTheSecondSonOfTheDragonFromTheVillageOfThe, inputChar, inputTheSecond);
            InRangeLoop(inputChar, inputTheSecond, toAscii, toAsciiTheSecondSonOfTheDragonFromTheVillageOfThe);
        }

        private static void InRangeLoop(char inputChar, char inputTheSecond, int toA, int toAtwo)
        {
         
            for (int i = toA + 1; i < toAtwo; i++)
            {
                char charWho = (char)i;
                Console.Write(charWho + " "  );
            }
        }
        private static void ToIntegerFromChar(int a, int b, char c, char d)
        {
            int toAscii = c;
            int toAsciiTheSecondSonOfTheDragonFromTheVillageOfThe = d;
        }
    }
}
