using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> toQuery = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] querry = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (querry[0]==1)
                {
                    toQuery.Push(querry[1]);
                }
                else if (querry[0]==2)
                {
                    toQuery.Pop();
                }
                else if (querry[0] == 3 && toQuery.Count>0)
                {
                    Console.WriteLine($"{toQuery.Max()}");
                }
                else if (querry[0]==4 && toQuery.Count>0)
                {
                    Console.WriteLine($"{toQuery.Min()}");
                }
            }
            Console.WriteLine(string.Join(", ", toQuery));
        }
    }
}
