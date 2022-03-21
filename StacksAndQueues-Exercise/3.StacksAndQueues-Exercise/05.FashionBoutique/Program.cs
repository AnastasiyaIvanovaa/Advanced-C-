using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);

            int racks = 1;
            int capacityOfTheRack = int.Parse(Console.ReadLine());
            int currentCapacity = capacityOfTheRack;

            while ( stack.Any())
            {
                int clothe = stack.Pop();

                currentCapacity -= clothe;
                if (currentCapacity<0)
                {
                    currentCapacity = capacityOfTheRack - clothe;
                    racks++;
                }
            }
            Console.WriteLine(racks);
}
    }
}
