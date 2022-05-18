using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                list.Add(box);
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SwapElements(list, indexes[0], indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void SwapElements<T>(List<Box<T>> boxes,int a,int b)
        {
            Box<T> temp = boxes[a];
            boxes[a] = boxes[b];
            boxes[b] = temp;
        }
    }
}
