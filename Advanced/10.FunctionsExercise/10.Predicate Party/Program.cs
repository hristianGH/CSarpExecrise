using System;
using System.Collections.Generic;
namespace _10.Predicate_Party
{
    class Program
    {
        public delegate List<string> PartyList(List<string> names);
        public delegate List<string> Split(string names);

        static void Main(string[] args)
        {
            Split namesList = (x) =>
            {
                List<string> names = new List<string>(x.Split());
                return names;
            };
            PartyList action = (x) =>
            {
                string c = Console.ReadLine();
                while (c != "Party!")
                {
                    string[] arr = c.Split();
                    List<string> copy = new List<string>(x);
                    if (arr[0] == "Remove")
                    {
                        if (arr[1] == "StartsWith")
                        {
                            foreach (var item in x)
                            {
                                if (item.StartsWith(arr[2]))
                                {
                                    copy.Remove(item);
                                }
                            }
                        }
                        else if (arr[1] == "EndsWith")
                        {
                            foreach (var item in x)
                            {
                                if (item.EndsWith(arr[2]))
                                {
                                    copy.Remove(item);
                                }
                            }
                        }
                        else if (arr[1] == "Lenght")
                        {
                            foreach (var item in x)
                            {
                                if (item.Length == int.Parse(arr[2]))
                                {
                                    copy.Remove(item);
                                }
                            }
                        }
                    }
                    else if (arr[0] == "Double")
                    {
                        if (arr[1] == "StartsWith")
                        {
                            foreach (var item in x)
                            {
                                if (item.StartsWith(arr[2]))
                                {
                                    copy.Add(item);
                                }
                                 
                            }
                        }
                        else if (arr[1] == "EndsWith")
                        {
                            foreach (var item in x)
                            {
                                if (item.EndsWith( arr[2]))
                                {
                                    copy.Add(item);
                                }
                            }
                        }
                        else if (arr[1] == "Length")
                        {
                            foreach (var item in x)
                            {
                                if (item.Length == int.Parse(arr[2]))
                                {
                                    copy.Add(item);
                                }
                            }
                        }
                    }

                            x = new List<string>(copy);
                    c = Console.ReadLine();

                }
                x.Sort();
                return x;
            };
           List<string> names = new List<string>(action(namesList(Console.ReadLine())));
            if (names.Count>0)
            {
            Console.WriteLine($"{string.Join(", ",names)} are going to the party!");

            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
