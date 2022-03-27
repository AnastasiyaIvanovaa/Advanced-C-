using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> number = new Dictionary<int, int>();
         

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (!number.ContainsKey(current))
                {
                    number.Add(current, 0);
                }
                number[current]++;
            }
            KeyValuePair<int, int> kvp = number.First(x => x.Value % 2 == 0);
            Console.WriteLine(kvp.Key);
        }
    }
}
