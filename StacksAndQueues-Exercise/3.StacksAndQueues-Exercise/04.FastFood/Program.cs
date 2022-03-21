using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(orders.Max());

            while (queue.Count>0)
            {
               
                if (foodQuantity>queue.Peek())
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    int client = queue.Dequeue();
                    queue.Enqueue(client);
                }
            }

            if (queue.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(", ", queue)}");
            }
            else 
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
