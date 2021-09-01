using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double capacitySales = double.Parse(Console.ReadLine());

            double commission = 0.0;

            if (capacitySales >= 0 && capacitySales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = capacitySales * 0.05;
                        break;
                    case "Varna":
                        commission = capacitySales * 0.045;
                        break;
                    case "Plovdiv":
                        commission = capacitySales * 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (capacitySales > 500 && capacitySales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = capacitySales * 0.07;
                        break;
                    case "Varna":
                        commission = capacitySales * 0.075;
                        break;
                    case "Plovdiv":
                        commission = capacitySales * 0.08;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (capacitySales > 1000 && capacitySales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = capacitySales * 0.08;
                        break;
                    case "Varna":
                        commission = capacitySales * 0.10;
                        break;
                    case "Plovdiv":
                        commission = capacitySales * 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (capacitySales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = capacitySales * 0.12;
                        break;
                    case "Varna":
                        commission = capacitySales * 0.13;
                        break;
                    case "Plovdiv":
                        commission = capacitySales * 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }

            if (capacitySales > 0)
            {
                if (city == "Sofia")
                {
                    Console.WriteLine($"{commission:f2}");
                }
                else if (city == "Varna")
                {
                    Console.WriteLine($"{commission:f2}");
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine($"{commission:f2}");
                }
            }
            
            

        }
    }
}
