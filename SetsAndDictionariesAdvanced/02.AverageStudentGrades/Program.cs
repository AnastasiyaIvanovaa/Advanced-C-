using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                decimal grade = decimal.Parse(command[1]);
                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<decimal>();
                }
                grades[name].Add(grade);
            }
            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var average = studentGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
