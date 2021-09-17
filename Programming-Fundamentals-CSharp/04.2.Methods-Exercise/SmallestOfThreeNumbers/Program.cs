using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            int smallestNum = SmallestNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallestNum);
        }

        private static int SmallestNum(int firstNum, int secondNum, int thirdNum)
        {
            int minNumber = secondNum;

            if (firstNum < secondNum)
            {
                minNumber = firstNum;
            }
            if (thirdNum < minNumber)
            {
                minNumber = thirdNum;
            }

            return minNumber;
        }
    }
}
