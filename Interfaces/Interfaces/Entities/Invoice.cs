using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax, double totalPayment)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Basic payment: {BasicPayment:F2}");
            sb.AppendLine($"Tax: {Tax:F2}");
            sb.AppendLine($"Total payment: {TotalPayment:F2}");

            return sb.ToString();
        }
    }
}

