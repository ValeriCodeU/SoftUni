using System;

namespace EnterNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());                
            }

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
