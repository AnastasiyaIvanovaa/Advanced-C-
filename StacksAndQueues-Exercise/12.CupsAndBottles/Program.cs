using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(cupsInput);
            int[] bottlesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bottels = new Stack<int>(bottlesInput);
            int wastedWater = 0;

            while (cups.Count>0 && bottels.Count>0)
            {
                int currentBottle = bottels.Pop();
                int currentCup=cups.Peek();
                if (currentBottle>=currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();
                }
                else
                {
                    while (bottels.Count>0)
                    {
                        currentCup -= currentBottle;
                        currentBottle = bottels.Pop();
                        if (currentCup-currentBottle<=0)
                        {
                            wastedWater += currentBottle - currentCup;
                            break;
                        }
                    }
                }
            }
            if (cups.Count>0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottels)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");

            }
        }
    }
}
