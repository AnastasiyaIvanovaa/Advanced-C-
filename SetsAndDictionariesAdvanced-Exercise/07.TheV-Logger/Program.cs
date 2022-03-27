using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> vloggers = new Dictionary<string,List<string>>();
            Dictionary<string, int> followers = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[]input=command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (input[1]=="joined")
                {
                    if (!vloggers.ContainsKey(input[0]))
                    {
                        vloggers.Add(input[0], new List<string>());
                        followers.Add(input[0], 0);
                    }
                }
                else if (input[1] == "followed")
                {
                    if (input[0] != input[2] && vloggers.ContainsKey(input[2]) && !vloggers[input[2]].Contains(input[0]) && vloggers.ContainsKey(input[0]))
                    {
                        vloggers[input[2]].Add(input[0]);
                        followers[input[0]]++;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
           
            int number = 0;
            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key).ToDictionary(x => x.Key, s => s.Value))
            {
                number ++;
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value.Count} followers, {followers[vlogger.Key]} following");
                if (number == 1)
                {
                    foreach (var item in vlogger.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
            }
        }
    }
}
