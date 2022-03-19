using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = input[i].ToString();
                if (currentElement=="(")
                {
                    indexes.Push(i);
                }
                else if (currentElement==")")
                {
                    int firstIndex=indexes.Pop();  
                    Console.WriteLine(input.Substring(firstIndex,i-firstIndex+1));
                }
            }
        }
    }
}
