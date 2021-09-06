using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            double sumOfProducts = 0;

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }                

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double singleProductPrice = 0;               

                if (input == "Nuts")
                {
                    singleProductPrice = 2;                 
                }

                else if (input == "Water")
                {
                    singleProductPrice = 0.7;
                }

                else if (input == "Crisps")
                {
                    singleProductPrice = 1.5;  
                }

                else if (input == "Soda")
                {
                    singleProductPrice = 0.8;
                }

                else if (input == "Coke")
                {
                    singleProductPrice = 1;
                }

                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }

                if (sum >= singleProductPrice)
                {
                    sum -= singleProductPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }

                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
