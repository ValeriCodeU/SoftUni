using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string occurrence = Console.ReadLine();
            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col].ToString() == occurrence)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;                        
                    }                    
                }
                if (isFound)
                {
                    break;
                }
                
            }            

            if (!isFound)
            {
                Console.WriteLine($"{occurrence} does not occur in the matrix ");
            }
        }
    }
}
