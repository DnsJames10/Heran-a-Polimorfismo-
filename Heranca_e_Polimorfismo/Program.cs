using System;
using System.Globalization;
using Heranca_e_Polimorfismo.Entities;

namespace Heranca_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" Comm, used or imported (c/u/i): ");
                char r = char.Parse(Console.ReadLine());
                if (r == 'c' || r == 'C')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    prod.Add(new Product(name, price));
                }
                else if (r == 'i' || r == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs free: ");
                    double customs = double.Parse(Console.ReadLine());
                    prod.Add(new ImportedProduct(name, price, customs));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manudacture (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    prod.Add(new UseProduct(name, price, date));
                }
                Console.WriteLine();
                Console.WriteLine("Price Tags: ");
                foreach(Product pro in prod)
                {
                    Console.WriteLine(pro.PriceTag());
                }

            }
        }
    }
}


