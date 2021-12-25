using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ");

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command[0] != "Revision")
            {
                string supermarket = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shops.ContainsKey(supermarket))
                {
                    shops.Add(supermarket, new Dictionary<string, double>());
                }

                shops[supermarket].Add(product, price);

                command = Console.ReadLine().Split(", ");
            }

            foreach (var supermarket in shops)
            {
                Console.WriteLine($"{supermarket.Key}->");
                foreach (var product in supermarket.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
