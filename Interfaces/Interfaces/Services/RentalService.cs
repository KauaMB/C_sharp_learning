using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Return - carRental.Pickup;

            double basicPayment = 0;

            if (duration.TotalHours <= 12)
                basicPayment = PricePerHour *Math.Ceiling(duration.TotalHours);
            else
            {
                double days = duration.TotalHours / 24;
                basicPayment = PricePerDay *Math.Ceiling(days);
            }

            carRental.Invoice = new Invoice(basicPayment, TaxService.Tax(basicPayment));
        }
    }
}
