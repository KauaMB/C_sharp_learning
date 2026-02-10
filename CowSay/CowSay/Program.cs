using System;
using System.Globalization;
using System.Text;

namespace CowSay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What will the cow say? ");
            string cowText = Console.ReadLine();

            string barra = new string('-', cowText.Length + 2);
            

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(barra);
            Console.WriteLine($"<{cowText}>");
            Console.WriteLine(barra);

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        \\   ^__^");
            Console.WriteLine("         \\  (oo)\\_______");
            Console.WriteLine("            (__)\\       )\\/\\");
            Console.WriteLine("                ||----w |");
            Console.WriteLine("                ||     ||");
            Console.ResetColor();
        }


    }
}