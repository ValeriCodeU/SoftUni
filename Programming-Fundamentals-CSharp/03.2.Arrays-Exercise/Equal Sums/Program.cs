using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // 1 2 3 3            

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int sumRight = 0;
                int sumLeft = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += arr[k];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    counter++;
                    break;
                }
            }
            if (counter != 1)
            {
                Console.WriteLine("no");
            }

        }
    }
}
