using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                Person person = new Person(data[0],int.Parse(data[1]));
                list.Add(person);
            }

            list = list.Where(x => x.Age > 30).OrderBy(x=>x.Name).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
