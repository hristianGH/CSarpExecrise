using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int asciiFromChar = 0;

            int wat = password.Length;
            int errors = 0;
            char[] passwordToCharacters = password.ToCharArray();

            IsPasswordLongEnough(wat, ref errors);

            DoesPasswordContainTwoDigits(passwordToCharacters, ref errors);

            OnlyLettersAndDigits(passwordToCharacters, ref errors);

            ErrorChecker(errors);
           
        }  

        private static void ErrorChecker(int errors)
        {
            if (errors < 1)
            {
                Console.WriteLine("Password is valid");

            }
        }

        private static void OnlyLettersAndDigits(char[] passwordToCharacters, ref int errors)
        {
            int asciiFromChar = 0;

            for (int i = 0; i < passwordToCharacters.Length; i++)
            {
                asciiFromChar = passwordToCharacters[i];
                if (asciiFromChar < 48 || asciiFromChar > 57 && asciiFromChar < 65 || asciiFromChar > 90 && asciiFromChar < 97 || asciiFromChar > 122)
                {

                    Console.WriteLine("Password must consist of only letters and digits ");
                    errors++;
                    Environment.Exit(0);
                }

            }
        }

        private static void DoesPasswordContainTwoDigits(char[] passwordToCharacters, ref int errors)
        {
            int digitCounter = 0;

            for (int i = 0; i < passwordToCharacters.Length; i++)
            {

                if (Char.IsNumber(passwordToCharacters[i]) == true)
                {
                    digitCounter++;
                }

            }

            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits ");
                errors++;
            }
        }

        private static int IsPasswordLongEnough(int wat, ref int errors)
        {
            if (wat < 6 || wat > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return errors++;
            }
            return wat;

        }
    }
}