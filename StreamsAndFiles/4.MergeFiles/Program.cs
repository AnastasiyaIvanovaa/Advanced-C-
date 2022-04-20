using System;
using System.IO;

namespace _4.MergeFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerOne = new StreamReader("../../../input1.txt"))
            {
                using (StreamReader readerTwo = new StreamReader("../../../input2.txt"))
                {
                    while (true)
                    {
                        using (StreamWriter writer = new StreamWriter("../../../result.txt",true))
                        {
                            string lineOne = readerOne.ReadLine();
                            string lineTwo = readerTwo.ReadLine();
                            if (lineOne!=null)
                            {
                                writer.WriteLine(lineOne);
                            }
                            if (lineTwo!=null)
                            {
                                writer.WriteLine(lineTwo);
                            }
                            if (lineOne==null && lineTwo==null)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
