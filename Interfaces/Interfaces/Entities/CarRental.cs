using Interfaces.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    internal class CarRental
    {
        public string CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return { get; set; }
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public CarRental(string carModel, DateTime pickup, DateTime @return, double pricePerHour, double pricePerDay)
        {
            if (!(@return > pickup))
            {
                throw new DomainException("Return date must be greater than pickup!");
            }

            CarModel = carModel;
            Pickup = pickup;
            Return = @return;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public double Duration()
        {
            return (Return - Pickup).TotalHours;
        }

        public double Payment()
        {
            double hours = Duration();

            if (hours <= 12)
                return PricePerHour * Math.Ceiling(Duration());
            else
            {
                double days = hours / 24;
                return PricePerDay * Math.Ceiling(days);
            }
        }

        public double Tax()
        {
            double tax = (Payment() <= 100) ? Payment() * 20 / 100 : Payment() * 15 / 100;
            return tax;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Basic payment: {Payment():F2}");
            sb.AppendLine($"Tax: {Tax():F2}");
            sb.AppendLine($"Total payment: {(Payment() + Tax()):F2}");
            
            return sb.ToString();
        }
}
}
