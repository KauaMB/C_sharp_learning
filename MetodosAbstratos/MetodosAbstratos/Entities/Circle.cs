using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Colors color, double radius) 
            : base(color)
        {
            Radius = radius; 
        }

        public override double Area()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
    }
}
