using GenericsExercise1.Services;
using System;

namespace GenericsExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintService service = new PrintService();

                Console.Write("How many values? ");
                int numberOfValues = int.Parse(Console.ReadLine());
                if (numberOfValues < 1 || numberOfValues > 10)
                {
                    throw new InvalidOperationException("Number must be between 1 and 10");
                }


                for (int i = 1; i <= numberOfValues; i++)
                {
                    int value = int.Parse(Console.ReadLine());
                    service.AddValue(value);
                }

                service.Print();

                Console.WriteLine();

                Console.WriteLine($"First: {service.First()}");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}