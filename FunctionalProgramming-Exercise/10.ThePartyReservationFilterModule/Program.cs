using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Func<string, string, bool> predicate = (name, word) => name.Substring(0, word.Length) == word;
            Func<string, string, bool> predicateEnd = (name, word) => name.Substring(name.Length - word.Length, word.Length) == word;
            Func<string, string, bool> contain = (a, b) => a.Contains(b);
            Func<int, int, bool> length = (a, b) => a == b;
            int lengthOne = 0;
            string[] current = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                current[i] = names[i];
            }
            string command = Console.ReadLine();
            
            while (command != "Print")
            {
                string[] toDo = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = toDo[0];
                if (toDo[1] == "Length")
                {
                    lengthOne = int.Parse(toDo[2]);
                }
                if (currentCommand.Contains("Add"))
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] != "0")
                        {
                            if (predicate(names[i], toDo[2]) && predicateEnd(names[i], toDo[2]) && length(names[i].Length, lengthOne) || contain(names[i], toDo[2]))
                            {
                                names[i] = "0";
                            }
                        }
                    }
                }
                else if (command.Contains("Remove"))
                {
                    for (int i = 0; 
                        i < current.Length; i++)
                    {
                        if (predicate(current[i], toDo[2]) || predicateEnd(current[i], toDo[2]) || length(current[i].Length, lengthOne) || contain(current[i],toDo[2]))
                        {
                            names[i]=current[i];
                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (names.Length > 0)
            {
                List<string> endList = new List<string>();
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i]!="0")
                    {
                        endList.Add(names[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", endList));
            }
        }
    }
}
