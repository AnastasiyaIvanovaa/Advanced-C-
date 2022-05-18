using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Box<string>> list = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<string> str = new Box<string>(Console.ReadLine());
                list.Add(str);
            }
            Box<string> value = new Box<string>(Console.ReadLine());
            int bigger = GetBiggerCount(list, value);
            Console.WriteLine(bigger);
        }

        private static int GetBiggerCount<T>(List<Box<T>> boxes, Box<T> box)
            where T: IComparable
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(box.Value)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
