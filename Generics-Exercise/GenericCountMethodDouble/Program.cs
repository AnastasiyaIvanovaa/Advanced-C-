using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> list = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                list.Add(box);
            }
            Box<double> element =new Box<double>( double.Parse(Console.ReadLine()));
            Console.WriteLine(CountGreaterDouble(list, element));
        }

        private static double CountGreaterDouble<T>(List<Box<T>> boxes,Box<T> value )
            where T : IComparable
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(value.Value)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
