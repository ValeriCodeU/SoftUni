using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            Dictionary<string, int> scores = new Dictionary<string, int>();

            foreach (var item in names)
            {
                scores.Add(item, 0);
            }

            string namePattern = @"[A-Za-z]";
            string digitPattern = @"[0-9]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currentName = "";
                MatchCollection racer = Regex.Matches(input, namePattern);

                foreach (Match item in racer)
                {
                    currentName += item.Value;
                }

                if (!scores.ContainsKey(currentName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                MatchCollection digit = Regex.Matches(input, digitPattern);

                int result = 0;

                foreach (Match item in digit)
                {
                    result += int.Parse(item.Value);
                }

                scores[currentName] += result;


                input = Console.ReadLine();
            }

            string[] finalScore = scores.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToArray();

            Console.WriteLine($"1st place: {finalScore[0]} \n2nd place: {finalScore[1]} \n3rd place: {finalScore[2]}");
        }
    }
}
