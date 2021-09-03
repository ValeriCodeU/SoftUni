using System;

namespace SumОfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int magicNum = int.Parse(Console.ReadLine());

            int counterCombinations = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counterCombinations++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counterCombinations} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counterCombinations} combinations - neither equals {magicNum}");
        }
    }
}
