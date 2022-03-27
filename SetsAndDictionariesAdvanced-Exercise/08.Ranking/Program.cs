using System;
using System.Collections.Generic;

namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input!= "end of contests")
            {
                string[] data = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (!passwords.ContainsKey(data[0]))
                {
                    passwords.Add(data[0], data[1]);
                }
                input=Console.ReadLine();
            }

            SortedDictionary<string, SortedDictionary<string, int>> points = new SortedDictionary<string, SortedDictionary<string, int>>();
            string command = Console.ReadLine();

            while (command!= "end of submissions")
            {
                string[] data = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string course = data[0];
                string password = data[1];
                string username = data[2];
                int currentPoints = int.Parse(data[3]);

                if (passwords.ContainsKey(course) && passwords[course]==password)
                {
                    if (!points.ContainsKey(username))
                    {
                        points.Add(username,new SortedDictionary<string, int> ());
                        points[username].Add(course, currentPoints);
                    }
                    else if (!points[username].ContainsKey(course))
                    {
                        points[username].Add(course, currentPoints);
                    }
                    else if (points[username][course]<currentPoints)
                    {
                        points[username][course] = currentPoints;
                    }
                    
                }
                command = Console.ReadLine();
            }

            int maxPoints = 0;
            string bestCandidat = string.Empty;


            foreach (KeyValuePair<string, SortedDictionary < string, int>> studentResults in points)
            {
                int result=0;
                foreach (KeyValuePair<string,int> studentResult in studentResults.Value)
                {
                    result+=studentResult.Value;
                }

                if (result>maxPoints)
                {
                    maxPoints = result;
                    bestCandidat = studentResults.Key;
                }
                
            }

            Console.WriteLine($"Best candidate is {bestCandidat} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in points)
            {
                Console.WriteLine(item.Key);

                foreach (var element in item.Value)
                {
                    Console.WriteLine($"#  {element.Key} -> {element.Value}");
                }
            }
        }
    }
}
