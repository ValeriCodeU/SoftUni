using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rowsLength = matrixSize[0];
            int colsLength = matrixSize[1];

            string[,] matrix = new string[rowsLength, colsLength];

            for (int row = 0; row < rowsLength; row++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < colsLength; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    int matrixRowIndex = int.Parse(command[1]);
                    int matrixColIndex = int.Parse(command[2]);
                    int swapRowIndex = int.Parse(command[3]);
                    int swapColIndex = int.Parse(command[4]);

                    if (matrixRowIndex < 0 || matrixColIndex < 0 || swapRowIndex >= rowsLength || swapColIndex >= colsLength)
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        string currentElement = matrix[matrixRowIndex, matrixColIndex];
                        matrix[matrixRowIndex, matrixColIndex] = matrix[swapRowIndex, swapColIndex];
                        matrix[swapRowIndex, swapColIndex] = currentElement;

                        for (int row = 0; row < rowsLength; row++)
                        {
                            for (int col = 0; col < colsLength; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }
        }
    }
}
