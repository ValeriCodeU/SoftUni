using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}
