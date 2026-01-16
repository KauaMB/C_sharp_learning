using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    internal class BrazilTaxService
    {
        public  static double Tax(double amount)
        {
            return (amount <= 100) ? (amount * 0.2) : (amount * 0.15);
        }
    }
}
