using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetMatrix(n);
        }

        private static void GetMatrix(int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
