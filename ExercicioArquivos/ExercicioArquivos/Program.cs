using ExercicioArquivos.Entities;
using System.Globalization;
using ExercicioArquivos.Exceptions;

namespace ExericioArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\PROJETOS\CSV archives\Exercise.csv";
            string targetPath = @"D:\PROJETOS\CSV archives\Result.csv";


            try
            {
                if (File.Exists(targetPath))
                {
                    throw new DomainException("The file already exists!");
                }

                List<Product> products = new List<Product>();
                string[] lines = File.ReadAllLines(sourcePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] lineArg = lines[i].Split(',');
                    products.Add(new Product(lineArg[0], double.Parse(lineArg[1], CultureInfo.InvariantCulture), int.Parse(lineArg[2])));
                }


                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product);
                    }
                }


                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("PROCCESS COMPLETED");
                Console.WriteLine("----------------------------------------------");

            }

            catch (DomainException e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

        }
    }
}