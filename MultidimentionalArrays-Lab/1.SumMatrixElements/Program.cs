using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions =Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = dimentions[0];
            int col = dimentions[1];
            int[,] matrix= new int[row,col];

            for(int i=0;i<row;i++)
            {
                int[] array=Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); 
                for(int j=0;j<col;j++)
                {
                    matrix[i,j] = array[j];
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
