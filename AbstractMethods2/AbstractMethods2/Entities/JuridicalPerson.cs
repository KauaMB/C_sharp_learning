using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AbstractMethods2.Entities
{
    internal class JuridicalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public JuridicalPerson(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            double totalTax = 0;

            totalTax = (NumberOfEmployees < 10) ? AnnualIncome * 0.16 : AnnualIncome * 0.14;

            return totalTax;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Taxes().ToString("F2")}";
        }
    }
}
