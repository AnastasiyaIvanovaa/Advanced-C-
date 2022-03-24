using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0],n[1]];

            for (int i = 0; i < n[0]; i++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int equalChars = 0;
            char current = '\0';

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j]==matrix[i,j+1] && matrix[i+1,j]==matrix[i+1,j+1] && matrix[i,j]==matrix[i+1,j])
                    {
                        equalChars++;
                        current=matrix[i,j];
                    }
                }
            }

            if (equalChars>=2)
            {
                Console.WriteLine(equalChars);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
