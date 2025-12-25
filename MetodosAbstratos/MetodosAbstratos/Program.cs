using MetodosAbstratos.Entities;
using System;
using System.Drawing;
using MetodosAbstratos.Entities.Enums;


namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape {i} data: ");
                Console.WriteLine("--------------------------------");
                Console.Write("Rectangle or circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());

                if (shapeType == 'r')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Colors color = Enum.Parse<Colors>(Console.ReadLine(), true);
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    shapes.Add(new Entities.Rectangle(color, width, height));
                }
                else if (shapeType == 'c')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Colors color = Enum.Parse<Colors>(Console.ReadLine(), true);
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    shapes.Add(new Circle(color, radius));
                }

            }
            Console.WriteLine("SHAPE AREAS: ");
            Console.WriteLine("---------------------------------------");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}