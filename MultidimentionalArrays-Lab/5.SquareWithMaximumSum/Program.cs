using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix =new int[rowsCols[0], rowsCols[1]];

            for (int i = 0; i < rowsCols[0]; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < rowsCols[1]; j++)
                {
                    matrix[i,j] = input[j];
                }
            }

            int sum = 0;
            int maxSum = 0;
            int row = 0;
            int col = 0;
            for (int i = 0; i < rowsCols[0]-1; i++)
            {
                for (int j = 0; j < rowsCols[1]-1; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (sum>maxSum)
                    {
                        row = i;
                        col = j;
                        maxSum = sum;
                    }
                }
            }

          
                    Console.WriteLine($"{matrix[row,col]} {matrix[row,col+1]}\n{matrix[row+1,col]} {matrix[row+1,col+1]}\n{maxSum}");
 
    
        }
    }
}
