using System;
using System.Linq;

namespace _3.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();    
            int[,] matrix = new int [rowsCols[0], rowsCols[1]];

            for (int i = 0; i < rowsCols[0]; i++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;

            if (rowsCols[0] >= 3 && rowsCols[1] >= 3)
            {

                for (int i = 0; i < matrix.GetLength(0) - 2; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                    {
                        int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            rowIndex = i;
                            colIndex = j;
                        }
                    }
                }
            }
            else
            {
                return;
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowIndex; i < rowIndex+3; i++)
            {
                for (int j = colIndex; j < colIndex+3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
