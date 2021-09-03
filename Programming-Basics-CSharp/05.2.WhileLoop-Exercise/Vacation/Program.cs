using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendDaysCounter = 0;

            while (tripMoney > currentMoney && spendDaysCounter < 5)
            {
                string commandMoney = Console.ReadLine();
                double manageMoney = double.Parse(Console.ReadLine());
                days++;

                if (commandMoney == "save")
                {
                    currentMoney += manageMoney;
                    spendDaysCounter = 0;
                }
                else if(commandMoney == "spend")
                {
                    spendDaysCounter++;

                    if (spendDaysCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                    }

                    currentMoney -= manageMoney;

                    if (manageMoney > currentMoney)
                    {
                        currentMoney = 0;
                    }
                }
            }
            if (currentMoney >= tripMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
