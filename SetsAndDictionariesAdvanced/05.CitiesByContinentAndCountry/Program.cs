using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var info = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var continent = inputData[0];
                var country = inputData[1];
                var town = inputData[2];

                if (!info.ContainsKey(continent))
                {
                    info.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!info[continent].ContainsKey(country))
                {
                    info[continent].Add(country, new List<string>());
                }
              
                    info[continent][country].Add(town);
                
            }

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key}:");
                var current = item.Value;

                foreach (var items in current)
                {
                    Console.WriteLine($"  {items.Key} -> {string.Join(", ",items.Value)}");
                }
            }
        }
    }
}
