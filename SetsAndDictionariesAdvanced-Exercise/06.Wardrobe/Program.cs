using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> colors = new Dictionary<string,Dictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!colors.ContainsKey(input[0]))
                {
                    colors.Add(input[0], new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!colors[input[0]].ContainsKey(clothes[j]))
                    {
                        colors[input[0]].Add(clothes[j], 0);
                    }
                    colors[input[0]][clothes[j]]++;
                }
            }

            string[] search = Console.ReadLine().Split();

            foreach (var color in colors)
            {
                string currentColor = search[0];
                string cloth = search[1];

                Console.WriteLine($"{color.Key} clothes:");
                if (currentColor==color.Key)
                    foreach (var item in color.Value)
                    {
                        if (item.Key==cloth)
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value}");
                        }
                    }
                
                    else
                    {
                        foreach (var item in color.Value)
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value}");
                        }
                    }

            }
        }
    }
}
