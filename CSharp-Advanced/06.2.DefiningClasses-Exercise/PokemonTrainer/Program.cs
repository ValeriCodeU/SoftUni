using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> players = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] splitter = input.Split();
                string trainerName = splitter[0];
                string pokemonName = splitter[1];
                string pokemonElement = splitter[2];
                int pokemonHealth = int.Parse(splitter[3]);

                Pokemon pokemonData = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!players.ContainsKey(trainerName))
                {                    
                    Trainer trainerData = new Trainer(trainerName);

                    players.Add(trainerName, trainerData);
                }

                players[trainerName].Pokemons.Add(pokemonData);

                input = Console.ReadLine();

            }

            input = Console.ReadLine();


            while (input != "End")
            {
                foreach (var player in players)
                {
                    if (player.Value.Pokemons.Any(x => x.Element == input))
                    {
                        player.Value.Badges += 1;
                    }

                    else
                    {
                        foreach (var pokemon in player.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        player.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players.Values.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{player.Name} {player.Badges} {player.Pokemons.Count}");
            }
        }
    }
}
