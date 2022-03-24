using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dimentions[0], dimentions[1]];

            for (int i = 0; i < dimentions[0]; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < dimentions[1]; j++)
                {
                    matrix[i, j] = data[j];
                }
            }

            string command = Console.ReadLine();

            while (command!="END")
            {
                string[] swap = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (swap.Length==5 && int.Parse(swap[1])>=0 && int.Parse(swap[1])<dimentions[0] && int.Parse(swap[2]) >= 0 && int.Parse(swap[2]) < dimentions[1] && int.Parse(swap[3]) >= 0 && int.Parse(swap[3]) < dimentions[0] && int.Parse(swap[4]) >= 0 && int.Parse(swap[4]) < dimentions[1] && swap[0]=="swap")
                {
                    string temp = matrix[int.Parse(swap[1]), int.Parse(swap[2])];
                    matrix[int.Parse(swap[1]), int.Parse(swap[2])] = matrix[int.Parse(swap[3]),int.Parse(swap[4])];
                    matrix[int.Parse(swap[3]), int.Parse(swap[4])] = temp;

                    for (int i = 0; i < dimentions[0]; i++)
                    {
                        for (int j = 0; j < dimentions[1]; j++)
                        {
                            Console.Write(matrix[i,j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
