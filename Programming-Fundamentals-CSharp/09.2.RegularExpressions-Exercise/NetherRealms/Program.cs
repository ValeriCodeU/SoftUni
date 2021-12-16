using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> healthResult = new Dictionary<string, int>();
            Dictionary<string, double> demageResult = new Dictionary<string, double>();

            string name = "";
            

            for (int i = 0; i < input.Length; i++)
            {
                name = input[i];

                string healthPattern = @"[^0-9\.\*\-\+\/]";
                string numbersPattern = @"[-\+]?[0-9]+(?:\.[0-9]+)?";
               string multiplayOrDivisionPattern = @"[*\/]";
                

                MatchCollection matches = Regex.Matches(input[i], healthPattern);

                int health = 0;

                foreach (Match item in matches)
                {
                    health += Convert.ToChar(item.Value);
                }

                MatchCollection sumOfNumbers = Regex.Matches(input[i], numbersPattern);

                double sum = 0;

                foreach (Match item in sumOfNumbers)
                {
                    sum += double.Parse(item.Value);
                }

                MatchCollection multiOrDiv = Regex.Matches(input[i], multiplayOrDivisionPattern);

                if (multiOrDiv.Count > 0)
                {
                    foreach (Match item in multiOrDiv)
                    {
                        if (item.Value == "*")
                        {
                            sum *= 2;
                        }
                    }

                    foreach (Match item in multiOrDiv)
                    {
                        if (item.Value == "/")
                        {
                            sum /= 2;
                        }
                    }
                }

                healthResult.Add(name, health);
                demageResult.Add(name, sum);
            }

            foreach (var item in healthResult.OrderBy(x => x.Key))
            {                
                Console.WriteLine($"{item.Key} - {item.Value} health, {demageResult[item.Key]:f2} damage");
            }
        }
    }
}
