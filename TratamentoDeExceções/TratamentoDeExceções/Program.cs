using System;
using TratamentoDeExceções.Entities;
using TratamentoDeExceções.Exceptions;

namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.WriteLine("-------------------------");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initial = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, initial, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for deposit: ");
                double deposit = double.Parse(Console.ReadLine());
                acc.Deposit(deposit);
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);

                Console.WriteLine($"New balance: {acc.Balance:F2}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}