using System;

namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                Person person = new Person(data[0],int.Parse(data[1]));
                family.AddMember(person);                
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
