using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int totalSum = 0;

            while (pokemons.Count != 0)
            {
                int indexOfPokemon = int.Parse(Console.ReadLine());
                int pokemonPower = 0;
                if (indexOfPokemon < 0)
                {
                    pokemonPower = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    totalSum += pokemonPower;
                    IncreasingAndDecrasingPokemons(pokemons, pokemonPower);
                }
                else if (indexOfPokemon > pokemons.Count -1)
                {
                    pokemonPower = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    totalSum += pokemonPower;
                    IncreasingAndDecrasingPokemons(pokemons, pokemonPower);
                }
                else
                {
                    pokemonPower = pokemons[indexOfPokemon];
                    totalSum += pokemonPower;
                    pokemons.RemoveAt(indexOfPokemon);

                    IncreasingAndDecrasingPokemons(pokemons, pokemonPower);
                }
            }

            Console.WriteLine(totalSum);
        }

        private static void IncreasingAndDecrasingPokemons(List<int> pokemons, int pokemonPower)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                int currPokemon = pokemons[i];
                if (currPokemon <= pokemonPower)
                {
                    pokemons[i] += pokemonPower;
                }
                else if (currPokemon > pokemonPower)
                {
                    pokemons[i] -= pokemonPower;
                }
            }
        }
    }
}
