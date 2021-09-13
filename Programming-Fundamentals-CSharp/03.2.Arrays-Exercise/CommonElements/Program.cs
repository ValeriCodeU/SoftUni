using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr2[i])
                    {
                        Console.Write(arr[j] + " ");
                    }
                }
            }
        }
    }
}
