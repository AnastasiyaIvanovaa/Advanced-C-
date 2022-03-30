using System;
using System.Collections.Generic;

namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Action<string> action = name => Console.WriteLine($"Sir {name}");
            Print(list, action);
        }

        private static void Print(List<string> list, Action<string> action)
        {
            for (int i = 0; i < list.Count; i++)
            {
                action(list[i]);
            }
        }
    }
}
