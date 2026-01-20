using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest (double amount, int months);
    }
}
