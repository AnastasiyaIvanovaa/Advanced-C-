using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, n).ToList();
            List<int> division = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>(); 
            foreach (var num in numbers)
            {
                if (division.All(d=>num%d==0))
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
