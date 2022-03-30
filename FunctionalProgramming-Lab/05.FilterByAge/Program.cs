using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> data = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!data.ContainsKey(input[0]))
                {
                    data.Add(input[0], int.Parse(input[1]));
                }
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Output(data, condition, age, format);
        }

        private static void Output(Dictionary<string, int> data, string condition, int age, string format)
        {
            if (condition == "younger")
            {
                foreach (var item in data)
                {
                    if (item.Value < age)
                    {
                        if (format == "name")
                        {
                            Console.WriteLine(item.Key);
                        }
                        else if (format == "age")
                        {
                            Console.WriteLine(item.Value);
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            else
            {
                foreach (var item in data)
                {
                    if (item.Value > age)
                    {
                        if (format == "name")
                        {
                            Console.WriteLine(item.Key);
                        }
                        else if (format == "age")
                        {
                            Console.WriteLine(item.Value);
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
