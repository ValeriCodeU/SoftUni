﻿using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            double incomePerDayPerBaker = numOfCakes * 45 + numOfWaffles * 5.80 + numOfPancakes * 3.20;

            double totalIncome = incomePerDayPerBaker * numOfBakers * numOfDays;

            totalIncome = totalIncome - totalIncome * 1 / 8;

            Console.WriteLine(totalIncome);

        }
    }
}
