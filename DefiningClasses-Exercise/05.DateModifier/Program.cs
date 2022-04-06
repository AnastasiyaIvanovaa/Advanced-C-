using System;

namespace _05.DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();   
            int days = DateModifier.GetDiffBetweenTwoDates(one, two);
            Console.WriteLine(days);
        }
    }
}
