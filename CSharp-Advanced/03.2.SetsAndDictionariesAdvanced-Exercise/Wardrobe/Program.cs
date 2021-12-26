using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {                
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] addClothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < addClothes.Length; j++)
                {
                    string clothe = addClothes[j];

                    if (!wardrobe[color].ContainsKey(clothe))
                    {
                        wardrobe[color].Add(clothe, 0);
                    }
                    wardrobe[color][clothe]++;
                }
            }

            string searching = Console.ReadLine();

            string[] searchingClothe = searching.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string findColor = searchingClothe[0];
            string findClothe = searchingClothe[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothe in item.Value)
                {
                    if (findColor == item.Key && findClothe == clothe.Key)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }                    
                }
            }
        }
    }
}
