using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());
            
            Func<List<int>, int, List<int>> func = (numbers, n) =>
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i]%n==0)
                    {
                        numbers.Remove(numbers[i]);
                    }
                }

                return numbers;
            };
            numbers = func(numbers,n);
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
