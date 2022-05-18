using System;

namespace MyTuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string name = $"{first[0]} {first[1]}";
            OwnTuple<string, string> one = new OwnTuple<string, string>(name, first[2]);
            string[] two = Console.ReadLine().Split();
            OwnTuple<string, int> ownTwo = new OwnTuple<string, int>(two[0],int.Parse(two[1]));
            string[] three = Console.ReadLine().Split();
            OwnTuple<int, double> threedata = new OwnTuple<int, double>(int.Parse(three[0]), double.Parse(three[1]));
            Console.WriteLine(one);
            Console.WriteLine(ownTwo);
            Console.WriteLine(threedata);
        }
    }
}
