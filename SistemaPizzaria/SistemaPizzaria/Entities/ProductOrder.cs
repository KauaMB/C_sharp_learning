using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPizzaria.Entities
{
    internal class ProductOrder
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product ChoosenProduct { get; set; }

        public ProductOrder(double price, int quantity, Product choosenProduct)
        {
            ChoosenProduct = choosenProduct;
            Quantity = quantity;
            Price = choosenProduct.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{ChoosenProduct.Name}, R${Price:F2}, Quantity: {Quantity}, Subtotal: {SubTotal()}";
        }
    }

}
