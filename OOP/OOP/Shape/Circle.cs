using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive");
            else 
                Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
