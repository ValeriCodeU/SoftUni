using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();         

            

            double totalMoney = 0.0;


            while (input != "NoMoreMoney")
            {

                double importMoney = double.Parse(input);
                


                if (importMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {importMoney:f2}");
                totalMoney += importMoney;
                input = Console.ReadLine();

            }
            

            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
