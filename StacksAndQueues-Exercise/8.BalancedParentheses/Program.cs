using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openParentheses = new Stack<char>();
            if (input.Length%2!=0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == '(' || currentChar=='[' || currentChar =='{')
                {
                    openParentheses.Push(currentChar);
                }
                else
                {
                    if (i==0)
                    {
                        break;
                    }
                    else
                    {
                        if (currentChar==')' && openParentheses.Peek()=='(')
                        {
                            openParentheses.Pop();
                        }
                        else if (currentChar == ']' && openParentheses.Peek()=='[')
                        {
                            openParentheses.Pop();
                        }
                        else if (currentChar == '}' && openParentheses.Peek()=='{')
                        {
                            openParentheses.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                
            }
            if (openParentheses.Count > 0)
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