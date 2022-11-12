using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dimentions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            long bigSum = long.MinValue;
            int row = 0;
            int col = 0;
            int n = int.Parse(Console.ReadLine());

            if (n < matrix.GetLength(0) && n < matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(0) - n+1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - n+1; j++)
                    {
                        sum = 0;
                        for (int k = 0; k < n; k++)
                        {
                            for (int l = 0; l < n; l++)
                            {
                                sum += matrix[i+k, j+l];
                            }
                        }

                        if (sum > bigSum)
                        {
                            bigSum = sum;
                            row = i;
                            col = j;
                        }
                    }
                }
            }
            for (int i = row; i < row + n; i++)
            {
                for (int j = col; j < col + n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(bigSum);

        }
    }
}
