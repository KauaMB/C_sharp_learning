using AbstractMethods2.Entities;
using System;

namespace AbstractMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> taxPayers = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.WriteLine("--------------------------------");

                Console.Write("Individual or company (i/c)? ");
                char individualOrCompany = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (individualOrCompany == 'i')
                {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine());

                    taxPayers.Add(new PhysicalPerson(name, annualIncome, healthExpenses));
                    Console.WriteLine();
                }
                else if (individualOrCompany == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new JuridicalPerson(name, annualIncome, numberOfEmployees));
                    Console.WriteLine();
                }
            }

                double totalTax = 0;

                Console.WriteLine("TAXES PAID: ");
                Console.WriteLine("---------------------------");
                foreach (Person person in taxPayers)
                {
                    totalTax += person.Taxes();
                    Console.WriteLine(person);
                }

                Console.WriteLine("-------------------------------");
                Console.WriteLine($"TOTAL TAX: $ {totalTax:F2}");
        }
    }
}