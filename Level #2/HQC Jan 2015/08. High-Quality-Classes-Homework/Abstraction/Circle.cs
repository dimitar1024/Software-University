using System;

namespace Abstraction
{
    class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
    }
}
