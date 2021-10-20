using System;
using System.Globalization;
using System.Collections.Generic;
using Polimorfismo.Entities;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            //Criando a lista de produtos
            List<Product> list = new List<Product>();
            Product news;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //criando if para cada tipo de produto e adicionando na lista
                if (x == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customfee));

                }
                else if (x == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (x == 'c')
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            //foreach para mostrar as etiquetas
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
