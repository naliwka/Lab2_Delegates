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
            // Зчитування даних з файлу
            List<Product> products = File.ReadAllLines("products.txt")
                                          .Skip(1) // пропустити перший рядок (заголовок)
                                          .Select(line => line.Split(';'))
                                          .Select(parts => new Product
                                          {
                                              Name = parts[0],
                                              Category = parts[1],
                                              Price = Convert.ToDouble(parts[2])
                                          })
                                          .ToList();

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
