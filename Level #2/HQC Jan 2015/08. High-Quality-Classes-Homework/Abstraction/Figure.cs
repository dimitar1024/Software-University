using System;

namespace Abstraction
{
    abstract class Figure
    {
        public virtual double Width { get; private set; }
        public virtual double Height { get; private set; }

        public Figure()
        {
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();

        public abstract double CalculatePerimeter();
    }
}
