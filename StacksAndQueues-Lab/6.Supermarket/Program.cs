using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");

        }
    }
}
