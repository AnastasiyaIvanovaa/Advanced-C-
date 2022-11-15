using System;
using System.Linq;

namespace _2._2X2SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = dimentions[0];
            int col = dimentions[1];    
            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int count = 0;
            for (int i = 0; i < row-1; i++)
            {
                for (int j = 0; j < col-1; j++)
                {
                    if (matrix[i,j]==matrix[i,j+1] && matrix[i,j]==matrix[i+1,j] && matrix[i,j]==matrix[i+1,j+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
