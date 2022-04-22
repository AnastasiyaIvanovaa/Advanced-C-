using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> words =new Dictionary<string, int>();
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {
                string word=reader.ReadLine();
                while (word != null)
                {
                    if (!words.ContainsKey(word))
                    {
                    words.Add(word, 0);
                    list.Add(word);
                    }
                    word = reader.ReadLine();
                }
            }
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                char[] splitters = new char[] { ' ', '-', ',', '.', '!', '?' };
                string text = reader.ReadToEnd();
                string[] vs = text.Split(splitters,StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < vs.Length; j++)
                    {
                        if (list[i].ToLower()==vs[j].ToLower())
                        {
                            words[list[i]]++;
                        }
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("../../../actualResults.txt", true))
            {
                foreach (var item in words)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../expectedResult.txt", true))
            {
                foreach (var item in words.OrderByDescending(w=>w.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            //Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. Matching should be case-insensitive. Write the results in file actualResults.txt. Sort the words by frequency in descending order and then compare the result with the file expectedResult.txt. Use the File class
        }
    }
}
