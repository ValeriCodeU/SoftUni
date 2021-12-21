using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsLength = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[rowsLength][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new long[row + 1];
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (col == 0 && row == 0)
                    {
                        jaggedArray[row][col] = 1;
                        continue;
                    }
                    if (row == 1 && col == 0 || row == 1 && col == 1)
                    {
                        jaggedArray[row][col] = 1;
                        continue;
                    }
                    if (col == 0 || col == jaggedArray[row].Length - 1)
                    {
                        jaggedArray[row][col] = 1;
                    }
                    else
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col - 1] + jaggedArray[row - 1][col];
                    }
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[i]));
            }
        }
    }
}
