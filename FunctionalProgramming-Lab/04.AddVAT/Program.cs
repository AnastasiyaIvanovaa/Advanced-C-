using System;
using System.Linq;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            VAT(prices);

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }

        }

        private static void VAT(double[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] *= 1.2;
            }
        }
    }
}
