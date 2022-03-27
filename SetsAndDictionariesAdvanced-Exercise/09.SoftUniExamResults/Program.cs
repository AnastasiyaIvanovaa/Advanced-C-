using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command!= "exam finished")
            {
                string[] data = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (data[1]=="banned")
                {
                    participants.Remove(data[0]);
                    command = Console.ReadLine();
                    continue;
                }
                if(!participants.ContainsKey(data[0]))
                {
                    participants.Add(data[0], int.Parse(data[2]));
                }
                else if(participants[data[0]]<int.Parse(data[2]))
                {
                    participants[data[0]] = int.Parse(data[2]);
                }
                if (!languages.ContainsKey(data[1]))
                {
                    languages.Add(data[1], 0);
                }
                languages[data[1]]++;
                command = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in participants.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var item in languages.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
