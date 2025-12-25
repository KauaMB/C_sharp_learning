using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using MetodosAbstratos.Entities.Enums;


namespace MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Colors Color { get; set; }

        public Shape(Colors color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
