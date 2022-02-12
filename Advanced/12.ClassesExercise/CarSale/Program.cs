using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CarSale
{
    class Program
    {
        public delegate Trainer PokeAdd(Trainer x, Pokemon poke);
        static void Main(string[] args)
        {
            PokeAdd pokeAdd = (x, y) =>
            {
                x.Pokemon.Add(y);
                return x;
            };
            string input = Console.ReadLine();
            List<Trainer> list = new List<Trainer>();
            while (input != "Tournament")
            {
                string[] arr = input.Split();
                Pokemon pokemon = new Pokemon(arr[1], arr[2], int.Parse(arr[3]));
                if (list.Any(z => z.Name == arr[0]))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Name == arr[0])
                        {
                            list[i].Pokemon.Add(pokemon);
                            break;
                        }
                    }
                }
                else
                {

                    Trainer trainer = new Trainer(arr[0], pokemon);
                    list.Add(trainer);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var item in list)
                {
                    foreach (var item2 in item.Pokemon)
                    {
                        if (item2.Element == input)
                        {
                            item.NumBadges++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            list.Sort(delegate (Trainer x, Trainer y) { return x.NumBadges.CompareTo(y.NumBadges); });
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.NumBadges} {item.Pokemon.Count}");

            }

        }
    }
}
class Trainer
{
    public Trainer(string name, Pokemon poke)
    {
        Name = name;
        NumBadges = 0;
        List<Pokemon> pokemons = new List<Pokemon>();
        pokemons.Add(poke);
        Pokemon = pokemons;
    }
    public string Name { get; set; }
    public int NumBadges { get; set; }
    public List<Pokemon> Pokemon { get; set; }
}
class Pokemon
{
    public Pokemon(string name, string type, int health)
    {
        Name = name;
        this.Element = type;
        Health = health;
    }
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }
}
