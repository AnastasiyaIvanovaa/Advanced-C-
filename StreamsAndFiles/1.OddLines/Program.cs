using System;
using System.IO;

namespace _1.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input1.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (currentRow != null)
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                        }
                        currentRow = reader.ReadLine();
                        row++;
                    }
                }
            }
        }
    }
}
