using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            double toysCounter = 0;
            double moneyHolder = 9;
            //double brotherMoney = 0;
            

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney = savedMoney + moneyHolder;
                    moneyHolder += 10;
                   
                    //brotherMoney++;
                }
                else
                {
                    toysCounter++;
                }
            }

            
            

            savedMoney = savedMoney + toysPrice * toysCounter;

            double diff = Math.Abs(washingmachinePrice - savedMoney);
            if (savedMoney < washingmachinePrice)
            {
                Console.WriteLine($"No! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
        }
    }
}
