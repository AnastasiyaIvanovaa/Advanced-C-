using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicateEvens = num => num % 2 == 0;
            Predicate<int> predicateOdds = num => num % 2 != 0;
            int[] limits=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            string command = Console.ReadLine();
            if (command=="odd")
            {
                for (int i = limits[0]; i <= limits[1]; i++)
                {
                    if (predicateOdds(i))
                    {
                        odds.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ",odds));
            }
            else if (command=="even")
            {
                for (int j = limits[0]; j <= limits[1]; j++)
                {
                    if (predicateEvens(j))
                    {
                        evens.Add(j);
                    }
                }
                Console.WriteLine(string.Join(" ",evens));
            }
        }
    }
}
