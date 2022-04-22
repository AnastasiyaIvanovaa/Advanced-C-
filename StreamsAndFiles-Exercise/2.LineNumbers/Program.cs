using System;
using System.IO;

namespace _2.LineNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lineCounter = 1;

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    int letterCounter = 0;
                    int symbolCounter = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsLetter(line[i]))
                        {
                            letterCounter++;
                        }
                        if (!char.IsLetter(line[i]) && line[i]!=' ')
                        {
                            symbolCounter++;
                        }
                    }
                    using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
                    {
                        writer.Write($"Line {lineCounter}: { line} ({letterCounter}) ({symbolCounter})\n");
                    }
                    lineCounter++;
                    line  = reader.ReadLine();
                }
                
            }
        }
    }
}
