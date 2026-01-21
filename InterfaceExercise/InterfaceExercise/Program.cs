using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System.ComponentModel;
using System.Globalization;

namespace InterfaceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            @Contract myContract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService cs = new ContractService(new PaypalService());

            cs.ProcessContract(myContract, months);

            foreach (Installment ins in myContract.Installments)
            {
                Console.WriteLine($"{ins.DueDate} - {ins.Amount:F2}");
            }

        }
    }
}