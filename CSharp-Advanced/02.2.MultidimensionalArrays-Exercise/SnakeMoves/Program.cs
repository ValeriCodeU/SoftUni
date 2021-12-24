using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string snakeText = Console.ReadLine();

            StringBuilder builder = new StringBuilder(snakeText);
           
            string direction = "right";
            int row = 0;
            int col = 0;

            string[,] snakeMatrix = new string[matrixSize[0], matrixSize[1]];

            for (int i = 0; i < matrixSize[0] * matrixSize[1] ; i++)
            {
                snakeMatrix[row, col] = builder[0].ToString();
                
                builder.Remove(0, 1);

                if (builder.Length == 0)
                {
                    builder.Append(snakeText);
                }
               
                if (direction == "right")
                {
                    col++;                    
                }
                else if (direction == "left")
                {
                    col--;
                }

                if (col == snakeMatrix.GetLength(1))
                {
                    row++;
                    col--;
                    direction = "left";
                }
                else if (col == - 1)
                {
                    row++;
                    col++;
                    direction = "right";
                }
            }

            for (int i = 0; i < snakeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < snakeMatrix.GetLength(1); j++)
                {
                    Console.Write(snakeMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
