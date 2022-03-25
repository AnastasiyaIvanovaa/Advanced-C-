using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> countOfTheValues = new Dictionary<double, int>();
            List<double> numbers = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!countOfTheValues.ContainsKey(numbers[i]))
                {
                    countOfTheValues.Add(numbers[i], 0);
                }
                countOfTheValues[numbers[i]]++; 
            }

            foreach (var item in countOfTheValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
