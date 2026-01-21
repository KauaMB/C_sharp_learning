using System;
using System.Collections.Generic;
using System.Text;
using InterfaceExercise.Entities;

namespace InterfaceExercise.Services
{
    internal class ContractService
    {
        public IOnlinePaymentService PaymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract (@Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double updatedQuota = PaymentService.Interest(basicQuota, i);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), PaymentService.PaymentFee(updatedQuota)));
            }
        }
    }
}
