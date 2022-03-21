using System;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arrays = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var lineParts = line.Split();
                arrays[i] = new int[lineParts.Length];
                for (int j = 0; j < lineParts.Length; j++)
                {
                    arrays[i][j] = int.Parse(lineParts[j]);
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                var commandParts = line.Split();
                var commandName = commandParts[0];
                if (commandName == "END")
                {
                    break;
                }
                var arrayIndex = int.Parse(commandParts[1]);
                var arrayElement = int.Parse(commandParts[2]);
                var value = int.Parse(commandParts[3]);
                if (arrayIndex < 0 || arrayIndex >= arrays.Length || arrayElement >= arrays[arrayIndex].Length || arrayElement < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (commandParts[0] == "Add")
                {

                    arrays[arrayIndex][arrayElement] += value;
                }
                else if (commandParts[0] == "Subtract")
                {
                    arrays[arrayIndex][arrayElement] -= value;
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arrays[i]));
            }
        }
    }
}
