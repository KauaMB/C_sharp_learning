using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AbstractMethods2.Entities
{
    internal class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name, double annualIncome, double healthExpenses)
            : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Taxes()
        {
            double totalTax = 0;

            totalTax = (AnnualIncome < 20000) ? AnnualIncome * 0.15 : AnnualIncome * 0.25;

            totalTax -= HealthExpenses * 0.5;

            return totalTax;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Taxes()}";
        }
    }
}
