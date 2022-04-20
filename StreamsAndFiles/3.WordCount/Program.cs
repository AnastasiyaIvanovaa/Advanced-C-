using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            using (StreamReader stream = new StreamReader("../../../words.txt"))
            {
                char[] splitter = new char[] {' ','.','?','!','-',','};
                string[] current = stream.ReadToEnd().Split(splitter,StringSplitOptions.RemoveEmptyEntries);
                using (StreamReader streamTwo = new StreamReader("../../../Input.txt"))
                {
                    
                    string[] two = streamTwo.ReadToEnd().Split(splitter,StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < current.Length; i++)
                    {
                        for (int j = 0; j < two.Length; j++)
                        {
                            if (current[i].ToLower()==two[j].ToLower())
                            {
                                if (!counts.ContainsKey(current[i]))
                                {
                                    counts.Add(current[i], 0);
                                }
                                counts[current[i]]++;
                            }
                        }
                    }
                }

                foreach (var item in counts.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
