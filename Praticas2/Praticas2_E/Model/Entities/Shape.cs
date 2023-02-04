using Praticas2_E.Enums;

namespace Praticas2_E.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
