using System;
using System.Collections.Generic;

namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names =Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            Func<string[],int,List<string>> name = (names,n) =>
            {
            for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length <= n)
                    {
                        list.Add(names[i]);
                    }
                }
            return list;
            };
            list = name(names, n);
            Console.WriteLine(string.Join("\n",list));
        }
    }
}
