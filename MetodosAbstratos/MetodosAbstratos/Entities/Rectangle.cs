using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MetodosAbstratos.Entities.Enums;


namespace MetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Colors color, double width, double height)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
