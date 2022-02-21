using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Food();

        }
        private static void Food()
        {
            int quantity = 0;
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Keys.IPerson> list = new List<Keys.IPerson>();
            while (input[0].ToUpper() != "END")
            {
                if (input.Length == 4)//Human Citizen
                {
                    list.Add(new Human(input[2], input[0], int.Parse(input[1]), input[3]));
                }
                else if (input.Length == 3)//Rebel
                {
                    list.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
                else
                {
                    foreach (var item in list)
                    {
                        if (input[0] == item.Name)
                        {
                            if (item.IsRebel == false)
                            {
                                quantity += 10;
                            }
                            else
                            {
                                quantity += 5;
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(quantity);
        }
        private static void Birthday()
        {
            //BirthDayExercise
            List<Keys.IBirthed> list = new List<Keys.IBirthed>();
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            while (input[0].ToUpper() != "END")
            {
                if (input[0].ToUpper() != "ROBOT")
                {
                    // Keys.IBirthed pet = new Pet(input[1] ,input[input.Length-1]);
                    list.Add(new Pet(input[1], input[input.Length - 1]));
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            input = Console.ReadLine().Split();
            bool IsMoreThanZero = false;
            foreach (var item in list)
            {
                int year = int.Parse(input[0]);
                if (item.Birthdate.Year == year)
                {
                    Console.WriteLine(item.Birthdate.ToString("dd/MM//yyyy"));
                    IsMoreThanZero = true;
                    //24/12/2000
                }
            }
            if (IsMoreThanZero == false)
            {
                Console.WriteLine("<empty output>");
            }
        }
        private static void FindID()
        {
            //FindID exercise
            List<Keys.Iidentefiable> ids = new List<Keys.Iidentefiable>();
            string[] input = Console.ReadLine().Split();
            while (input[0].ToUpper() != "END")
            {
                var id = input[input.Length - 1];
                ids.Add(new Robot(id, input[0]));
                input = Console.ReadLine().Split();
            }
            input[0] = Console.ReadLine();
            foreach (var item in ids)
            {
                if (item.ID.EndsWith(input[0]))
                {
                    Console.WriteLine(item.ID);
                }
            }
        }
    }
}
