using System;

namespace _7.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] inputData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = inputData[col];
                }
            }

            while (true)
            {
                int maxAttackedKnightsCount = 0;
                int row = -1;
                int col = -1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char symbol = board[i, j];
                        if (symbol!='K')
                        {
                            continue;
                        }
                        int count = GetCountOfAttackedKnights(board,row, col);
                    }
                }
            }

            //
        }

        private static int GetCountOfAttackedKnights(char[,] board,int row, int col)
        {
            int count = 0;

            if (ContainsKnight(board,row-2,col-1))
            {
                count++;
            }
            if (ContainsKnight(board, row - 2, col +1))
            {
                count++;
            }
            if (ContainsKnight(board, row -1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row - 1, col +2))
            {
                count++;
            }
            if (ContainsKnight(board, row +1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row +1, col +2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col + 1))
            {
                count++;
            }
            return count;
        }

        private static bool ContainsKnight(char[,] board, int row, int col)
        {
            if (!isValidCell(row,col,board.GetLength(0)))
            {
                return false;
            }
            return board[row, col] == 'K';
        }

        private static bool isValidCell(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
