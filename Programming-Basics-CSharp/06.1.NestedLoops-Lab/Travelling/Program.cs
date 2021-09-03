using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double countMoney = 0;

                while (countMoney < budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    countMoney += sum;
                }
                if (countMoney >= budget)
                {
                    Console.WriteLine($"Going to {input}!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
