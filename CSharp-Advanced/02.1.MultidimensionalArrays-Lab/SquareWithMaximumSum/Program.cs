using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowLength = sizeMatrix[0];
            int colLength = sizeMatrix[1];

            int[,] matrix = new int[rowLength, colLength];

            for (int row = 0; row < rowLength; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int maxSquareSum = int.MinValue;
            int rowIndexResult = 0;
            int colIndexResult = 0;
            

            for (int row = 0; row < rowLength - 1; row++)
            {
                int currentSquareSum = 0;

                for (int col = 0; col < colLength - 1; col++)
                {
                    currentSquareSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSquareSum > maxSquareSum)
                    {
                        maxSquareSum = currentSquareSum;
                        rowIndexResult = row;
                        colIndexResult = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndexResult, colIndexResult]} {matrix[rowIndexResult, colIndexResult + 1]}");
            Console.WriteLine($"{matrix[rowIndexResult + 1, colIndexResult]} {matrix[rowIndexResult + 1, colIndexResult + 1]}");
            Console.WriteLine(maxSquareSum);           
        }
    }
}
