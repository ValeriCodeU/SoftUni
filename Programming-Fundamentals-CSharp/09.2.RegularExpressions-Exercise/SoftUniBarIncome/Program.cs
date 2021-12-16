using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-z][a-z]+)%[^%\.\|\$]*?<(?<product>\w+)>[^%\.\|\$]*?\|(?<count>[0-9]+)\|[^%\.\|\$]*?(?<price>[0-9]+\.?[0-9]+?)\$[^%\.\|\$]*?";

            string input = Console.ReadLine();

            double totalPrice = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string price = match.Groups["price"].Value;
                string quantity = match.Groups["count"].Value;

                double customerSum = double.Parse(price) * int.Parse(quantity);
                totalPrice += customerSum;

                Console.WriteLine($"{match.Groups["customer"]}: {match.Groups["product"]} - {customerSum:f2}");


                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
