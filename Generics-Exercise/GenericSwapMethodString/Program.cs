using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                list.Add(box);
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SwapElements(list, indexes[0], indexes[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
 
        }
        private static void SwapElements<T>(List<Box<T>> boxes,int first, int second)
        {
            if (first < 0 || first >= boxes.Count || second < 0 || second >= boxes.Count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            Box<T> box = boxes[first];
            boxes[first] = boxes[second];
            boxes[second] = box;
        }
    }
}
