﻿using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowLength = sizeMatrix[0];
            int colLength = sizeMatrix[1];

            int[,] matrix = new int[rowLength, colLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }            

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);                
            }           
        }
    }
}
