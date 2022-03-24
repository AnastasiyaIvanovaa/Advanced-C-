using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char [dimentions[0],dimentions[1]];

            char[] snake =Console.ReadLine().ToCharArray();
            Queue<char> queue = new Queue<char>(snake);

            for (int i = 0; i < dimentions[0]; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < dimentions[1]; j++)
                    {
                        char current = queue.Dequeue();
                        queue.Enqueue(current);
                        matrix[i,j] = current;
                    }
                }
                else
                {
                    for (int k = dimentions[1]-1; k >= 0; k--)
                    {
                        char current = queue.Dequeue();
                        queue.Enqueue(current);
                        matrix[i, k] = current;
                    }
                }
            }

            for (int i = 0; i < dimentions[0]; i++)
            {
                for (int j = 0; j < dimentions[1]; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
