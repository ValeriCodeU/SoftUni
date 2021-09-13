using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lastNumber = arr[arr.Length - 1]; //няма числа отдясно, последният int винаги е най-голям

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int biggestNum = 0;

                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        biggestNum = arr[i];
                    }
                    else
                    {
                        break;
                    }

                    if (j + 1 == arr.Length - 1)
                    {
                        Console.Write(biggestNum + " ");
                    }
                }
            }

            Console.Write(lastNumber);
        }
    }
}
