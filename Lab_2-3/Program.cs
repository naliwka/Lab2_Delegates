using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read list of products from file
            List<Product> products = File.ReadAllLines("products.txt")
                                          .Skip(1) // skip first line
                                          .Select(line => line.Split(';'))
                                          .Select(parts => new Product
                                          {
                                              Name = parts[0],
                                              Category = parts[1],
                                              Price = Convert.ToDouble(parts[2])
                                          })
                                          .ToList();
            // Group products by category
            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine(group.Key + ":");
                foreach (var product in group)
                {
                    Console.WriteLine($" {product.Name} - {product.Price}");
                }
                Console.WriteLine();
            }
        }
    }
}
