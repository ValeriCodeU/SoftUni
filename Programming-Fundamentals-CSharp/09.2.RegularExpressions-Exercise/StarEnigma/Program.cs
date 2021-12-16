using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"[SsTtAaRr]";

                MatchCollection matches = Regex.Matches(input, pattern);

                int count = matches.Count;

                for (int j = 0; j < input.Length; j++)
                {
                    char currentChar = Convert.ToChar(input[j] - count);
                    input = input.Remove(j, 1);
                    input = input.Insert(j, currentChar.ToString());
                }

                string patternSoldier = @"@(?<planet>[A-za-z]+)[^\@\-!:>]*?:[^\@\-!:>]*?(?<population>[0-9]+)[^\@\-!:>]*?![^\@\-!:>]*?(?<attackType>[A|D])[^\@\-!:>]*?![^\@\-!:>]*?->[^\@\-!:>]*?(?<soldierCount>[0-9]+)\.*?";

                Match soldierAttack = Regex.Match(input, patternSoldier);

                if (!soldierAttack.Success)
                {
                    continue;
                }

                if (soldierAttack.Groups["attackType"].Value == "A")
                {

                    attackedPlanets.Add(soldierAttack.Groups["planet"].Value);
                }
                else if (soldierAttack.Groups["attackType"].Value == "D")
                {
                    destroyedPlanets.Add(soldierAttack.Groups["planet"].Value);
                }

            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }            
        }
    }
}
