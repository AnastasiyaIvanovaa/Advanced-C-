using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse));
            numbers.Sort();
            if (numbers.Count>3)
            {
                for (int i = numbers.Count - 1; i >= numbers.Count-3; i--)
                {
                    Console.Write(numbers[i]+ " ");
                }
            }
            else
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i]+" ");
                }
            }

        }
    }
}
