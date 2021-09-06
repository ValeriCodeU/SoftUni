using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int searchingNum = inputNum;

            int sum = 0;

            while (inputNum > 0)
            {
                int currentNum = inputNum % 10;               

                int factioriel = 1;

                for (int i = 1; i <=currentNum; i++)
                {
                    factioriel *= i;
                }

                sum += factioriel;

                inputNum /= 10;
            }

            if (searchingNum == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
