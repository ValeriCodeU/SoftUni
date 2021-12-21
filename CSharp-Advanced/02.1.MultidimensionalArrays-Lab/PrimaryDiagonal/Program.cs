using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[n, n];

            int sumDiagonal = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = values[col];
                }
            }

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumDiagonal += squareMatrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
