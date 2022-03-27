using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
        SortedDictionary<char, int> map = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!map.ContainsKey(text[i]))
                {
                    map.Add(text[i], 0);
                }
                map[text[i]]++;
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
