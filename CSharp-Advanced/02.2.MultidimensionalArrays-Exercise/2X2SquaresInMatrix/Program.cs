using System;
using System.Collections.Generic;
using System.Linq;

namespace _2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowsLength = matrixSize[0];
            int colsLength = matrixSize[1];

            List<string> equalElements = new List<string>();

            string[,] matrix = new string[rowsLength, colsLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int equalCount = 0;

            for (int row = 0; row < rowsLength - 1; row++)
            {
                for (int col = 0; col < colsLength - 1; col++)
                {
                    string squareElementOne = matrix[row, col];
                    string squareElementTwo = matrix[row, col + 1];
                    string squareElementThree = matrix[row + 1, col];
                    string squareElementFour = matrix[row + 1, col + 1];

                    equalElements.Add(squareElementOne);
                    equalElements.Add(squareElementTwo);
                    equalElements.Add(squareElementThree);
                    equalElements.Add(squareElementFour);

                    if (equalElements.All(x => x == squareElementOne))
                    {
                        equalCount++;
                    }
                    else
                    {
                        equalElements.Clear();
                    }
                }
            }

            Console.WriteLine(equalCount);
        }
    }
}
