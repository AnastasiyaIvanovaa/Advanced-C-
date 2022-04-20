using System;
using System.IO;

namespace _5.SliceAFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../slice.txt", FileMode.Open))
            {
                int chunk = (int)reader.Length / 4;
                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[1];
                    int count = 0;
                    using (FileStream writer = new FileStream($"../../../slice-{i + 1}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (count<chunk)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count+=buffer.Length;
                        }
                        if (reader.Position != reader.Length && i == 3)
                        {
                            byte[] lastBuffer = new byte[(int)reader.Length - reader.Position];
                            reader.Read(lastBuffer, 0, lastBuffer.Length);
                            writer.Write(lastBuffer, 0, lastBuffer.Length);
                        }
                    }
                }
            }
        }
    }
}
