using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[numRows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[row] = new double[elements.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = elements[col];
                }
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);


                if (command[0] == "Add")
                {
                    if (row >= 0 && col >= 0 && row < jaggedArray.Length && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (row >= 0 && col >= 0 && row < jaggedArray.Length && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }
    }
}
