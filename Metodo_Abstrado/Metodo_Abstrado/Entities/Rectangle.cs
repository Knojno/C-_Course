﻿using System;
using System.Collections.Generic;
using System.Text;
using Metodo_Abstrado.Entities.Enums;

namespace Metodo_Abstrado.Entities
{
    class Rectangle : Shape
    {
        public double  Width { get; set; }
        public double Height { get; set; }
        public  Rectangle(double width, double height,Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width*Height;
        }
    }
}
