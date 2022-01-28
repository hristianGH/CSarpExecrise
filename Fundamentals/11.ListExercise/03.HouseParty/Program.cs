using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfcomands = int.Parse(Console.ReadLine());

            List<string> invitedPeople = new List<string>(numOfcomands);

            for (int i = 0; i < numOfcomands; i++)
            {
                string[] comand = Console.ReadLine().Split();

                CheckList(invitedPeople, comand);
               
            }
            Console.WriteLine(string.Join(Environment.NewLine,invitedPeople));
        }

        private static void CheckList(List<string> invitedPeople, string[] comand)
        {
            if (comand.Length == 3)
            {
                if (invitedPeople.Contains(comand[0]))
                {
                    Console.WriteLine($"{comand[0]} is already in the list!");

                }
                else
                {
                    invitedPeople.Add(comand[0]);
                }

            }
            else
            {
                if (invitedPeople.Contains(comand[0]))
                {
                    invitedPeople.Remove(comand[0]);
                  

                }
                else
                {
                    Console.WriteLine($"{comand[0]} is not in the list!");
                }

            }
        }
    }
}
