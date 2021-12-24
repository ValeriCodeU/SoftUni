using System;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = elements[col];
                }
            }

            int removeKnights = 0;
            

            while (true)
            {
                int maxAttack = 0;
                int rowIndexKnight = 0;
                int colIndexKnight = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int currentKnightAttack = 0;

                        if (board[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInSide(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (IsInSide(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentKnightAttack++;
                        }

                        if (currentKnightAttack > maxAttack)
                        {
                            maxAttack = currentKnightAttack;
                            rowIndexKnight = row;
                            colIndexKnight = col;
                        }
                    }
                }

                if (maxAttack == 0)
                {
                    Console.WriteLine(removeKnights);
                    break;
                }
                else
                {
                    board[rowIndexKnight, colIndexKnight] = '0';
                    removeKnights++;
                }
            }            
        }

        private static bool IsInSide(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}
