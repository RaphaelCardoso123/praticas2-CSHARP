using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProductExerc
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products:");
            int nProd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nProd; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common (c), Used (u) or Imported (i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                if (type == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYY)");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

            Console.ReadLine();
        }
    }
}
