using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string command = Console.ReadLine();

            while (command!="PARTY")
            {
                char symbol = command[0];
                if (char.IsDigit(symbol))
                {
                    Vip.Add(command);
                }
                else
                {
                    regular.Add(command);
                }

                command=Console.ReadLine();
            }

            while (command!="END")
            {
                if (Vip.Contains(command))
                {
                    Vip.Remove(command);
                }
                else if (regular.Contains(command))
                {
                    regular.Remove(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(Vip.Count+regular.Count);
            if (Vip.Count>0)
            {
                foreach (var item in Vip)
                {
                    Console.WriteLine(item);
                }
            }
            if (regular.Count>0)
            {
                foreach (var item in regular)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
