using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double percentageGroup1 = 0;
            double percentageGroup2 = 0;
            double percentageGroup3 = 0;
            double percentageGroup4 = 0;
            double percentageGroup5 = 0;

            int numOfNumbersGroup1 = 0;
            int numOfNumbersGroup2 = 0;
            int numOfNumbersGroup3 = 0;
            int numOfNumbersGroup4 = 0;
            int numOfNumbersGroup5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());


                if (currentNum < 200)
                {
                    numOfNumbersGroup1++;
                }

                else if (currentNum >= 200 && currentNum <= 399)
                {
                    numOfNumbersGroup2++;
                }
                else if (currentNum >= 400 && currentNum <= 599)
                {
                    numOfNumbersGroup3++;
                }
                else if (currentNum >= 600 && currentNum <= 799)
                {
                    numOfNumbersGroup4++;
                }

                else
                {
                    numOfNumbersGroup5++;
                }
            }

            percentageGroup1 = numOfNumbersGroup1 * 100.0 / n;
            percentageGroup2 = numOfNumbersGroup2 * 100.0 / n;
            percentageGroup3 = numOfNumbersGroup3 * 100.0 / n;
            percentageGroup4 = numOfNumbersGroup4 * 100.0 / n;
            percentageGroup5 = numOfNumbersGroup5 * 100.0 / n;

            Console.WriteLine($"{percentageGroup1:f2}%");
            Console.WriteLine($"{percentageGroup2:f2}%");
            Console.WriteLine($"{percentageGroup3:f2}%");
            Console.WriteLine($"{percentageGroup4:f2}%");
            Console.WriteLine($"{percentageGroup5:f2}%");
        }
    }
}
