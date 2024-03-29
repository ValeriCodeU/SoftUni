﻿using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 1; i <=lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalSum += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    totalSum += mousePrice;
                }
                if (i % 6 == 0)
                {
                    totalSum += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    totalSum += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
