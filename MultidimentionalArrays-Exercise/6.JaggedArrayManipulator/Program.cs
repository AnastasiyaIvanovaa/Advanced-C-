using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jagged[i] = new double[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jagged[i][j] = input[j];
                }
            }

            for (int i = 0; i < jagged.Length-1; i++)
            {
                if (jagged[i].Length==jagged[i+1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int k = 0; k < jagged[i].Length; k++)
                    {
                        jagged[i][k] /= 2;
                    }
                    for (int m = 0; m < jagged[i+1].Length; m++)
                    {
                        jagged[i+1][m] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] operation = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (operation[0]== "Add" && int.Parse(operation[1])>=0 && int.Parse(operation[1])<jagged.Length && int.Parse(operation[2])>=0 && int.Parse(operation[2])<jagged[int.Parse(operation[1])].Length)
                {
                    jagged[int.Parse(operation[1])][int.Parse(operation[2])] += double.Parse(operation[3]);
                }

                else if (operation[0] == "Subtract" && int.Parse(operation[1]) >= 0 && int.Parse(operation[1]) < jagged.Length && int.Parse(operation[2]) >= 0 && int.Parse(operation[2]) < jagged[int.Parse(operation[1])].Length)
                {
                    jagged[int.Parse(operation[1])][int.Parse(operation[2])] -= double.Parse(operation[3]);
                }
                command = Console.ReadLine();
            }
            foreach (double[] item in jagged)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
