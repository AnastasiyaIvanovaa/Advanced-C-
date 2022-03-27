using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> sides = new Dictionary<string, SortedSet<string>>();
            string command = Console.ReadLine();
            string forceSideOne = string.Empty;
            string forceSideTwo = string.Empty;
            while (command!= "Lumpawaroo")
            {
                if (command.Contains(" | "))
                {
                    string[] data = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    if (!sides.ContainsKey(data[0]))
                    {
                        sides.Add(data[0], new SortedSet<string> {data[1]});
                        if (forceSideOne==string.Empty)
                        {
                            forceSideOne = data[0];
                        }
                        else if (forceSideTwo==string.Empty)
                        {
                            forceSideTwo = data[0];
                        }
                    }
                    if (!sides[data[0]].Contains(data[1]))
                    {
                        sides[data[0]].Add(data[1]);
                    }
                }
                else if (command.Contains(" -> "))
                {
                    string[] data = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    if (!sides[data[1]].Contains(data[0]))
                    {
                        sides[data[1]].Add(data[0]);
                        Console.WriteLine($"{data[0]} joins the {data[1]} side!");
                        if (data[1]==forceSideOne)
                        {
                            sides[forceSideTwo].Remove(data[0]);
                        }
                        else
                        {
                            sides[forceSideOne].Remove(data[0]);
                        }
                    }
                    else if (sides[data[1]].Contains(data[0]))
                    {
                        if (data[1] == forceSideOne)
                        {
                            sides[data[1]].Remove(data[1]);
                            sides[forceSideTwo].Add(data[0]);
                            Console.WriteLine($"{data[0]} joins the {data[1]} side!");

                        }
                        else
                        {
                            sides[data[1]].Remove(data[0]);
                            sides[forceSideOne].Add(data[1]);
                            Console.WriteLine($"{data[0]} joins the {data[1]} side!");

                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var item in sides.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                    Console.WriteLine($" {item.Key}, Members: {item.Value.Count}");
                if (item.Value.Count > 0)
                {
                    foreach (var element in item.Value)
                    {
                        Console.WriteLine($"! {element}");
                    }
                }
            }
        }
    }
}
