using System;
using System.Collections.Generic;

namespace _06.RecordUniqeNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
