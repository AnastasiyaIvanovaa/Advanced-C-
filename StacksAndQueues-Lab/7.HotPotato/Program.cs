using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> names = new Queue<string>(input);
            int count = int.Parse(Console.ReadLine());

            while (names.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    string queue = names.Dequeue();
                    names.Enqueue(queue);
                }
                string removed = names.Dequeue();
                Console.WriteLine($"Removed {removed}");
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
