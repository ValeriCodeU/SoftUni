using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Input              Output
            // 2 1 1 2 3 3 2 2 2 1      2 2 2
            // 1 1 1 2 3 1 3 3          1 1 1
            // 4 4 4 4 4                4 4 4
            // 0 1 1 5 2 2 6 3 3        1 1

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int totalCounter = 0;
            int result = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > totalCounter)
                {

                    totalCounter = counter;
                    result = array[i];
                }
            }

            for (int i = 0; i < totalCounter; i++)
            {
                Console.Write(result + " ");
            }
        }
    }
}
