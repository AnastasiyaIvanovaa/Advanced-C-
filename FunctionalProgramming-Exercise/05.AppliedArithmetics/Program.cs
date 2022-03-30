using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, List<int>> addOne = numbers =>
             {
                 for (int i = 0; i < numbers.Count; i++)
                 {
                     numbers[i] += 1;
                 }
                 return numbers;
             };
             Func<List<int>, List<int>> multiply = numbers =>
              {
                  for (int i = 0; i < numbers.Count; i++)
                  {
                      numbers[i] *= 2;
                  }
                  return numbers;
              };
              Func<List<int>, List<int>> subtract = numbers =>
              {
                  for (int i = 0; i < numbers.Count; i++)
                  {
                      numbers[i] -= 1;
                  }
                  return numbers;
              };
            Action<List<int>> print = numbers =>
            {
                Console.WriteLine(String.Join(" ", numbers));
            };
string command = Console.ReadLine();
            while (command!="end")
            {
                if (command=="add")
                {
                    numbers = addOne(numbers);
                }
                else if (command=="multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command=="subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command=="print")
                {
                    print(numbers);
                }
                command = Console.ReadLine();
            }

        }
    }
}
