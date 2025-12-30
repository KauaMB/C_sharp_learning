using System;
using System.Collections.Generic;
using System.Text;
using TratamentoDeExceções.Exceptions;

namespace TratamentoDeExceções.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance!");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The withdraw must be smaller than the withdraw limit!");
            }

            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Insert a value bigger than 0!");
            }
            Balance += amount;
        }
    }
}