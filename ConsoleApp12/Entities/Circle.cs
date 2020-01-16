﻿using System;
using Metodos_e_classes_abstratas.Entities.Enums;

namespace Metodos_e_classes_abstratas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
