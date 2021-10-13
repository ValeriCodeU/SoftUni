using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("motes", 0);
            dictionary.Add("fragments", 0);
            dictionary.Add("shards", 0);

            bool isFound = false;
            int counter = 0;
            int quantity = 0;

            while (!isFound)
            {
                string[] materials = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < materials.Length; i++)
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        quantity = int.Parse(materials[i]);
                    }
                    else
                    {
                        if (!dictionary.ContainsKey(materials[i]))
                        {
                            dictionary.Add(materials[i], 0);
                        }
                        dictionary[materials[i]] += quantity;
                    }

                    if (dictionary["motes"] >= 250 || dictionary["shards"] >= 250 || dictionary["fragments"] >= 250)
                    {
                        if (materials[i] == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                        }
                        else if (materials[i] == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                        }
                        else if (materials[i] == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                        }

                        dictionary[materials[i]] = dictionary[materials[i]] - 250;
                        isFound = true;
                        break;
                    }
                }
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Key == "motes" || item.Key == "fragments" || item.Key == "shards")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                if (item.Key != "motes" && item.Key != "fragments" && item.Key != "shards")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }               
            }
        }
    }
}
