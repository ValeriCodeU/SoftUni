using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {


            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());



            TotalPrice(product, quantity);


        }

        private static void TotalPrice(string product, int quantity)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = quantity * 1.50;
            }

            else if (product == "water")
            {
                price = quantity * 1.00;
            }

            else if (product == "coke")
            {
                price = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                price = quantity * 2.00;
            }

            Console.WriteLine($"{price:f2}");


        }       



    }
    
}
