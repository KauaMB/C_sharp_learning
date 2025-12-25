using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethods2.Entities
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;        
        }

        public abstract double Taxes();
    }
}
