using Praticas2_E.Enums;
using Praticas2_E.Entities;
using System;
using System.Globalization;

namespace Praticas2_E.Model.Entities
{
    class Circle : Shape 
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
