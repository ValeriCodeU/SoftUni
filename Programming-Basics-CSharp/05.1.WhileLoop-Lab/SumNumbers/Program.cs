using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumNumbers = 0;


            while (n >= sumNumbers)
            {
                int currentNum = int.Parse(Console.ReadLine());
                

                sumNumbers += currentNum;

                if (sumNumbers == n)
                {
                    break;
                    
                }


            }

            Console.WriteLine(sumNumbers);
        }
    }
}
