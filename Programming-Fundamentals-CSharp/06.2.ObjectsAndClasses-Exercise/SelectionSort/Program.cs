using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 11, 5, 2, 7, 3, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
