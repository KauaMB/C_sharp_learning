using Interfaces.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    internal class CarRental
    {
        public Vehicle CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(Vehicle carModel, DateTime pickup, DateTime @return)
        {
            if (!(@return > pickup))
            {
                throw new DomainException("Return date must be greater than pickup!");
            }

            CarModel = carModel;
            Pickup = pickup;
            Return = @return;
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

       
}
}
