using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] output1 = new int[n];
            int[] output2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNumber = arr[0];
                int secondNumber = arr[1];

                if (i % 2 == 0)
                {
                    output1[i] = firstNumber;
                    output2[i] = secondNumber;
                }
                else
                {
                    output1[i] = secondNumber;
                    output2[i] = firstNumber;
                }
            }
            Console.Write(string.Join(" ", output1));
            Console.WriteLine();
            Console.Write(string.Join(" ", output2));
        }
    }
}
