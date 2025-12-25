using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExercise.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime date) 
            : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price:F2} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
