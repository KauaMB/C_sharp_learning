using SistemaPizzaria.Entities;
using System;

namespace SistemaPizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---CLIENT DATA---");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();

            Client c = new Client(name, phoneNumber);

            Console.WriteLine();

            Console.WriteLine("---ORDER DATA---");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order o = new Order(DateTime.Now, status, c);

            Console.Write("How many items? ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Type the data of item #{i + 1}");
                Console.Write($"Pizza name: ");
                string pizzaName = Console.ReadLine();
                Console.Write($"Pizza price: ");
                double pizzaPrice = double.Parse(Console.ReadLine());

                Product pizza = new Product(pizzaName, pizzaPrice);

                Console.Write($"Quantity: ");
                int pizzaQuantity = int.Parse(Console.ReadLine());

                o.AddItem(new ProductOrder(pizza.Price, pizzaQuantity, pizza));
                Console.WriteLine();
            }

            Console.WriteLine(o);
            

        }
    }
}