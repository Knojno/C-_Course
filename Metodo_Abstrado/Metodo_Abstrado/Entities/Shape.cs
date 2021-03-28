using System;
using System.Collections.Generic;
using System.Text;
using Metodo_Abstrado.Entities.Enums;

namespace Metodo_Abstrado.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape()
        {

        }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
       
    }
}
