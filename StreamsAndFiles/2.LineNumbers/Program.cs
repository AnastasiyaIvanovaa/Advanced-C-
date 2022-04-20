using System;
using System.IO.Stream;

namespace _2.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int row = 0;
                    while (line!=null)
                    {
                        writer.WriteLine($"{++row}. {line}");
                        line = reader.ReadLine();

                    }
                }
            }
        }
    }
}
