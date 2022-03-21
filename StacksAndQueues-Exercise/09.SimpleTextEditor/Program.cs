using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = "";
            int n = int.Parse(Console.ReadLine());
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0]=="1")
                {
                    for (int j = 1; j < commands.Length; j++)
                    {
                        letters += commands[j];
                    }
                    history.Push(letters);
                }
               else if (commands[0] == "2")
                {
                    letters = letters.Substring(0, letters.Length - int.Parse(commands[1]));
                    history.Push(letters);
                }
                else if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1]) - 1;
                    Console.WriteLine(letters[index]);
                }
                else if (commands[0] == "4")
                {
                    if (history.Count==0)
                    {
                        letters = "";
                        continue;
                    }
                    else if(history.Peek()==letters && history.Count>0)
                    {
                        history.Pop();
                    }
                    letters = history.Pop();
                }
            }
        }
    }
}
