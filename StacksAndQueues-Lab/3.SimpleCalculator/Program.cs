
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> calculator = new Stack<string>(input.Reverse());
            
            int result = int.Parse(calculator.Pop());

            while (calculator.Count>0)
            {
                string current = calculator.Pop();
                if (current == "+")
                {
                    result+= int.Parse(calculator.Pop());
                }
                else if (current == "-")
                {
                    result-=int.Parse(calculator.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
