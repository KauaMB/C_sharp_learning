using HerancaPolimorfismo.Entities;
using System;

namespace HerancaPolimorfismo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        Console.WriteLine("===================================");

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Employee #{i + 1} data:");
            Console.WriteLine("----------------------------------------");
            Console.Write("Outsourced (y/n)? ");
            char isOutsourced = char.Parse(Console.ReadLine());

            while (isOutsourced != 'n' && isOutsourced != 'y')
            {
                Console.WriteLine("Enter a valid value!");
                Console.Write("Outsourced (y/n)? ");
                isOutsourced = char.Parse(Console.ReadLine());
            }

            if (isOutsourced == 'y')
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine());

                Console.WriteLine();

                employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else if (isOutsourced == 'n')
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.WriteLine();

                employees.Add(new Employee(name, hours, valuePerHour));
            }
        }

        Console.WriteLine("PAYMENTS: ");

        Console.WriteLine();

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }

    }
}