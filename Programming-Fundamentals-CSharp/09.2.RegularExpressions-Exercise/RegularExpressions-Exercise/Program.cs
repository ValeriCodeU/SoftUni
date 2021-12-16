using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<product>[A-z]+)<<(?<price>[0-9]+\.?[0-9]+?)!(?<quantity>[0-9]+)";

            decimal sum = 0;

            List<string> list = new List<string>();

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string price = match.Groups["price"].Value;
                string quantity = match.Groups["quantity"].Value;
                string poduct = match.Groups["product"].Value;

                sum += decimal.Parse(price) * int.Parse(quantity);

                list.Add(poduct);

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
