using System;
using System.Collections.Generic;

namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Action<string> action = word => Console.WriteLine(word);
        {
            for (int i = 0; i < list.Count; i++)
            {
                action(list[i]);
            }
        }
        }
    }
}
