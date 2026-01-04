using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace ExercicioArquivos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;    
            Price = price;
            Quantity = quantity;
        }

        public string TotalValue()
        {
            return (Price * Quantity).ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {TotalValue()}";
        }
    }
}
