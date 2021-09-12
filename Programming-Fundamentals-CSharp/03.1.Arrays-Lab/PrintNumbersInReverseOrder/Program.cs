using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            //3. variant ---------------------

            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = numbers.Length - 1; i >=0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //2. variant -------------

            //for (int i = 0; i < n; i++)
            //{
            //    numbers[numbers.Length - 1 - i] = int.Parse(Console.ReadLine()); 
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            //1. variant ---------------

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int[] reversedNumbers = new int[numbers.Length];

            //for (int i = 0; i < reversedNumbers.Length; i++)
            //{
            //    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            //}

            //for (int i = 0; i < reversedNumbers.Length; i++)
            //{
            //    Console.Write(reversedNumbers[i] + " ");
            //}
        }
    }
}
