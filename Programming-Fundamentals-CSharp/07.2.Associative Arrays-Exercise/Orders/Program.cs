using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();

            Dictionary<string, List<double>> items = new Dictionary<string, List<double>>();

            while (products[0] != "buy")
            {
                string product = products[0];
                int quantity = int.Parse(products[2]);
                double price = double.Parse(products[1]);

                if (!items.ContainsKey(product))
                {
                    items.Add(product, new List<double>());
                  
                    items[product].Add(0);
                    items[product].Add(0);
                }

                items[product][0] = price;
                items[product][1] += quantity;               

                products = Console.ReadLine().Split();
            }

            foreach (var (key, value) in items)
            {
                Console.WriteLine($"{key} -> {value[0] * value[1]:f2}");
            }
        }
    }
}
