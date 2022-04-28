using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, int> func = name =>
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                return sum;
            };

            for (int i = 0; i < names.Count; i++)
            {
                if (func(names[i])>=n)
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
           
            
            
            //Write a program that traverses a collection of names and returns the first name, whose sum of characters is equal to or larger than a given number N, which will be given on the first line. Use a function that accepts another function as one of its parameters. Start off by building a regular function to hold the basic logic of the program. Something along the lines of Func<string, int, bool>. Afterwards create your main function which should accept the first function as one of its parameters.
        }
    }
}
