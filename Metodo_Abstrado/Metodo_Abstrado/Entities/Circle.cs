using System;
using System.Collections.Generic;
using System.Text;
using Metodo_Abstrado.Entities.Enums;

namespace Metodo_Abstrado.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radiu, Color color) : base (color)
        {
            Radius = radiu;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
