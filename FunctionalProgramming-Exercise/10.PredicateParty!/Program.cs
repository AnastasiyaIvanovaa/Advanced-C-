using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> current = new List<string>();
            Func<string,string,bool> predicate = (name,word) => name.Substring(0,word.Length)==word;
            Func<string,string,bool> predicateEnd = (name,word) => name.Substring(name.Length-word.Length,word.Length)==word;
            Func<int, int, bool> length = (a, b) => a == b;
            int lengthOne = 0;
            string command = Console.ReadLine();
            while (command!="Party!")
            {
                string[] toDo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = toDo[0];
                if (toDo[1]=="Length")
                {
                     lengthOne = int.Parse(toDo[2]);
                }
                if (currentCommand=="Remove")
                {
                    for(int i =0;i<names.Count;i++)
                    {
                        if (!predicate(names[i], toDo[2]) && !predicateEnd(names[i], toDo[2]) && !length(names[i].Length,lengthOne))
                        {
                            current.Add(names[i]);
                        }
                    }
                }
                else if (currentCommand =="Double")
                {
                    for (int i=0;i<names.Count;i++)
                    {
                        if (predicate(names[i], toDo[2]) || predicateEnd(names[i], toDo[2]) || length(names[i].Length, lengthOne))
                        {
                            current.Add(names[i]);
                        }
                        current.Add(names[i]);
                    }
                }
                if ( names.Count>0)
                {
                    names.Clear();
                names.AddRange(current);
                }
              
                command = Console.ReadLine();
                if (current.Count>0)
                {
                    current.Clear();
                }
            }
            if (names.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(String.Join(", ",names));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
