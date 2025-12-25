using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPizzaria.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<ProductOrder> OrderedItems { get; set; } = new List<ProductOrder>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(ProductOrder item)
        {
            OrderedItems.Add(item);
        }

        public double Total()
        {
            double totalSum = 0;

            foreach (ProductOrder item in OrderedItems)
            {
                totalSum += item.SubTotal();
            }

            return totalSum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---ORDER RECEIPT---");
            sb.AppendLine($"Moment: {Moment.ToString("dd/MM/yyyy HH/mm/ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("---ORDERED ITEMS---");
            foreach (ProductOrder item in OrderedItems)
            {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine($"Total price: R${Total():F2}");

            return sb.ToString();
        }
    }

}