using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[n, n];

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    squareMatrix[row, col] = elements[col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonalSum += squareMatrix[row, col];

                        secondaryDiagonalSum += squareMatrix[row, (squareMatrix.GetLength(0) - 1) - row];                        
                    }
                }
            }

            int diffDiagonals = primaryDiagonalSum - secondaryDiagonalSum;

            Console.WriteLine(Math.Abs(diffDiagonals));
        }
    }
}
