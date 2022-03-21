using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                }
                else
                {
                 if (input[i]==')' && stack.Peek()=='(')
                {
                    stack.Pop();
                }
               else if (input[i] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (input[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }
                }
            if (stack.Count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
