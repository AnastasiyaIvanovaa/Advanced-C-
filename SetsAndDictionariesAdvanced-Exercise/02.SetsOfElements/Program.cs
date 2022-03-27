using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] count = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            for (int i = 0; i < count[0]; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0;  j< count[1]; j++)
            {
                m.Add(int.Parse(Console.ReadLine()));
            }

        n.IntersectWith(m);
            Console.WriteLine(String.Join(" ",n));
            
        }
    }
}
