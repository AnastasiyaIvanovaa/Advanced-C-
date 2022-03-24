using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sumPrimary = 0;
            int sumSecondary = 0;

            for (int i = 0; i < n; i++)
            {
                sumPrimary+=matrix[i, i];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                sumSecondary += matrix[i, n - i - 1];
            }
            Console.WriteLine($"{Math.Abs(sumSecondary-sumPrimary)}");
        }
    }
}
