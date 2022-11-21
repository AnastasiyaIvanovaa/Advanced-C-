using System;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = n[0];
            int col = n[1];
            string[,] array = new string[row, col];
            int playerRow = 0;
            int playerCol = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string data = Console.ReadLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = data[j].ToString();
                    if (data[j].ToString() == "P")
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            string command = Console.ReadLine();
            bool isDead = false;
            bool isWon = false;
            for (int i = 0; i < command.Length; i++)
            {
                string currentCommand = command[i].ToString();
                if (currentCommand == "L" && IsInside(playerRow, playerCol - 1, array.GetLength(0), array.GetLength(1)))
                {
                    if (array[playerRow, playerCol - 1] == "B")
                    {
                        isDead = true;
                    }
                    else
                    {
                        array[playerRow, playerCol] = ".";
                        array[playerRow, playerCol - 1] = "P";
                    }
                    playerCol--;
                }
                else if (currentCommand == "L" && !IsInside(playerRow, playerCol - 1, array.GetLength(0), array.GetLength(1)))
                {
                    isWon = true;
                    array[playerRow, playerCol] = ".";

                }
                if (currentCommand == "R" && IsInside(playerRow, playerCol + 1, array.GetLength(0), array.GetLength(1)))
                {
                    if (array[playerRow, playerCol + 1] == "B")
                    {
                        isDead = true;
                    }
                    else
                    {
                        array[playerRow, playerCol] = ".";
                        array[playerRow, playerCol + 1] = "P";
                    }
                    playerCol++;
                }
                else if (currentCommand == "R" && !IsInside(playerRow, playerCol + 1, array.GetLength(0), array.GetLength(1)))
                {
                    isWon = true;
                    array[playerRow, playerCol] = ".";
                    playerCol++;
                }
                if (currentCommand == "U" && IsInside(playerRow - 1, playerCol, array.GetLength(0), array.GetLength(1)))
                {
                    if (array[playerRow - 1, playerCol] == "B")
                    {
                        isDead = true;
                    }
                    else
                    {
                        array[playerRow, playerCol] = ".";
                        array[playerRow - 1, playerCol] = "P";
                    }
                    playerRow--;
                }
                else if (currentCommand == "U" && !IsInside(playerRow - 1, playerCol, array.GetLength(0), array.GetLength(1)))
                {
                    isWon = true;
                    array[playerRow, playerCol] = ".";
                    playerRow--;
                }
                if (currentCommand == "D" && IsInside(playerRow + 1, playerCol, array.GetLength(0), array.GetLength(1)))
                {
                    if (array[playerRow + 1, playerCol] == "B")
                    {
                        isDead = true;
                    }
                    else
                    {
                        array[playerRow, playerCol] = ".";
                        array[playerRow + 1, playerCol] = "P";
                    }
                    playerRow++;
                }
                else if (currentCommand == "D" && !IsInside(playerRow + 1, playerCol, array.GetLength(0), array.GetLength(1)))
                {
                    isWon = true;
                    array[playerRow, playerCol] = ".";
                    playerRow++;
                }
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[j, k] == "B")
                        {
                            if (IsInside(j - 1, k, row, col))
                            {
                                if (array[j - 1, k] == "P")
                                {
                                    isDead = true;
                                }
                                array[j - 1, k] = "b";
                            }
                            if (IsInside(j, k + 1, row, col))
                            {
                                if (array[j, k + 1] == "P")
                                {
                                    isDead = true;
                                }
                                array[j, k + 1] = "b";
                            }
                            if (IsInside(j + 1, k, row, col))
                            {
                                if (array[j + 1, k] == "P")
                                {
                                    isDead = true;
                                }
                                array[j + 1, k] = "b";
                            }
                            if (IsInside(j, k - 1, row, col))
                            {
                                if (array[j, k - 1] == "P")
                                {
                                    isDead = true;
                                }
                                array[j, k - 1] = "b";
                            }
                        }
                    }
                }
                for (int l = 0; l < array.GetLength(0); l++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        if (array[l, m] == "b")
                        {
                            array[l, m] = "B";
                        }
                    }
                }
                if (isDead)
                {
                    PrintMatrix(array);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                else if (isWon)
                {

                    PrintMatrix(array);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    Environment.Exit(0);

                }

            }
        }

        static bool IsInside(int row, int col, int matrixRow, int matrrixCol)
        {
            if (row >= 0 && row < matrixRow && col >= 0 && col < matrrixCol)
            {
                return true;
            }
            return false;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}
