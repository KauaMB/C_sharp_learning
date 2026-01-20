using System;
using System.Globalization;

namespace InterfaceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int numberOfIntallments = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIntallments; i++)
            {

            }
        }
    }
}