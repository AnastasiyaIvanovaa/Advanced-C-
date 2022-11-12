using System;
using System.Linq;

namespace MultidimentionalArraysMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arrayOne = new int[n, m];
            int[,] arrayTwo = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    arrayOne[i, j] = input[j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    arrayTwo[i, j] = input[j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayOne[i, j] = arrayOne[i, j] * arrayTwo[j, i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arrayOne[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
