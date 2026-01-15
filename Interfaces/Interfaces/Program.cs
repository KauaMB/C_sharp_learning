using Interfaces.Entities;
using Interfaces.Exceptions;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Transactions;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter rental data: ");
                Console.Write("Car model: ");
                Vehicle carModel = new Vehicle(Console.ReadLine());
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime @return = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
               
                CarRental test = new CarRental(carModel, pickup, @return);

                Console.Write("Enter price per hour: ");
                double pricePerHour = double.Parse(Console.ReadLine());
                Console.Write("Enter price per day: ");
                double pricePerDay = double.Parse(Console.ReadLine());

               

                Console.WriteLine();
                Console.WriteLine("INVOICE: ");
                Console.WriteLine(test);

            }
            catch (DomainException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
        }
    }
}