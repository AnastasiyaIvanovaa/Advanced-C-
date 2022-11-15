using System;
using System.Linq;

namespace _3.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = dimentions[0];
            int col = dimentions[1];
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int maxSum = 0;
            int rowMax = 0;
            int colMax = 0;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < matrix.GetLength(0) - count + 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - count + 1; j++)
                {
                    int currentSum = 0;
                    for (int k = i; k < i + count; k++)
                    {
                        for (int m = j; m < j + count; m++)
                        {
                            currentSum += matrix[k, m];
                        }
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            rowMax = i;
                            colMax = j;
                        }
                    }

                }
            }
            Console.WriteLine("Sum = " + maxSum);

            for (int i = rowMax; i <= rowMax + count - 1; i++)
            {
                for (int j = colMax; j <= colMax + count - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
