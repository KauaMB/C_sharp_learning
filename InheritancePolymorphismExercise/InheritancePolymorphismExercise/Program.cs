using InheritancePolymorphismExercise.Entities;
using System;
using System.Globalization;

namespace InheritancePolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("--------------------------------------");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productQuality = char.Parse(Console.ReadLine());

                if (productQuality == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    products.Add(new Product(name, price));
                }
                else if (productQuality == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (productQuality == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = Double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    products.Add(new ImportedProduct(name, price, customs));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            Console.WriteLine("--------------------------------");

            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}