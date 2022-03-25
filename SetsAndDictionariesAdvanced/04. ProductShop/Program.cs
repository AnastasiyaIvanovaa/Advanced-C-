using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Revision")
                {
                    break;
                }
                var parts = line.Split(", ");
                var shop = parts[0];
                var product = parts[1];
                var price = double.Parse(parts[2]);
                if (!products.ContainsKey(shop))
                {
                    products.Add(shop, new Dictionary<string, double>());
                }
                if (!products[shop].ContainsKey(product))
                {
                    products[shop].Add(product, price);
                }
                else
                {
                    products[shop].Add(product, price);
                }
            }
            foreach (var shop in products)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
