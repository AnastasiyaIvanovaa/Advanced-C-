using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
          var list= FirstLetterIsUpper( input, new List<string> ());
            Console.WriteLine(string.Join(Environment.NewLine,list));
        }

         static List<string> FirstLetterIsUpper(string[] input, List<string> firstIsUpper)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i][0];
                if (char.IsUpper(symbol))
                {
                    firstIsUpper.Add(input[i]);
                }
            }
            return firstIsUpper;
        }
    }
}
