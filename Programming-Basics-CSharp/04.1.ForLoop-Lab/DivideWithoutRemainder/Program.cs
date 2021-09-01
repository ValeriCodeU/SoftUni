using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double numGroup1 = 0;
            double numGroup2 = 0;
            double numGroup3 = 0;

            double percentageGroup1 = 0;
            double percentageGroup2 = 0;
            double percentageGroup3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());


                if(currentNum % 2 == 0)
                {
                    numGroup1++;
                }
                if (currentNum % 3 == 0)
                {
                    numGroup2++;
                }
                if (currentNum % 4 == 0)
                {
                    numGroup3++;
                }

                
            }


            percentageGroup1 = numGroup1 * 100 / n;
            percentageGroup2 = numGroup2 * 100 / n;
            percentageGroup3 = numGroup3 * 100 / n;


            Console.WriteLine($"{percentageGroup1:f2}%");
            Console.WriteLine($"{percentageGroup2:f2}%");
            Console.WriteLine($"{percentageGroup3:f2}%");
        }
    }
}
