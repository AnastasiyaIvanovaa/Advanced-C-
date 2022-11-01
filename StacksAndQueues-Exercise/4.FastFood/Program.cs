using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(data);
            Console.WriteLine(orders.Max());

            while (orders.Count>0)
            {

                int currentOrder = orders.Peek();
                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
      
        }

            if (orders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
