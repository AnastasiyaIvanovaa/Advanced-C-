using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];

            char[,] field = new char[n, m];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }
                else if (direction == 'U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }

                if (!isValid(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }
                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }

                if (isWon || isDead)
                {
                    break;
                }

                PrintField(field);

                string result = "";
                if (isWon)
                {
                    result += "won";
                }
                else
                {
                    result += "dead";
                }
                Console.WriteLine($"{result}: {playerRow}{playerCol}");
            }

        }
        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {
            int rowsLength = field.GetLength(0);
            int colsLength = field.GetLength(1);

            foreach (int[] item in bunniesCoordinates)
            {
                int row = item[0];
                int col = item[1];

                if (isValid(row - 1, col, rowsLength, colsLength))
                {
                    field[row - 1, col] = 'B';
                }
                if (isValid(row + 1, col, rowsLength, colsLength))
                {
                    field[row + 1, col] = 'B';
                }
                if (isValid(row, col - 1, rowsLength, colsLength))
                {
                    field[row, col - 1] = 'B';
                }
                if (isValid(row, col + 1, rowsLength, colsLength))
                {
                    field[row, col + 1] = 'B';
                }
            }
        }
        private static List<int[]> GetBunniesCoordinates(char[,] field)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLongLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunniesCoordinates;
        }

        private static bool isValid(int row, int col, int n, int m)
        {
            return row >= 0 && col >= 0 && row < n && col < m;
        }
    }
}
