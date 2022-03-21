﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> elements = new Stack<int>();
           int[] toPush = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < toPush.Length; i++)
            {
                elements.Push(toPush[i]);
            }

            for (int i = 0; i < operations[1]; i++)
            {
                elements.Pop();
            }

            if (elements.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (elements.Contains(operations[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallest = elements.Min();
                    Console.WriteLine(smallest);
                }
            }
        }
    }
}
