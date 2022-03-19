using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
           Stack<int> numbers = new Stack<int> (input);
            string command = Console.ReadLine().ToLower();

            while (command!="end")
            {
                string[] operation = command.Split();
                string toDo = operation[0];

                if (toDo=="add")
                {
                    numbers.Push(int.Parse(operation[1]));
                    numbers.Push(int.Parse(operation[2]));
                }
                else if (toDo=="remove")
                {
                    if (int.Parse(operation[1]) <= numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(operation[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");

        }
    }
}
