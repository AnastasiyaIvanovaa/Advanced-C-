using System;
using System.Linq;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Sum());

        }
    }
}
