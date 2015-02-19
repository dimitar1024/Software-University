using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Circle : IShape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Radius is positive number");
                    }
                    else
                    {
                        radius = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            Console.WriteLine("Area of the circle is {0:f2}", area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            Console.WriteLine("Area of the circle is {0:f2}", perimeter);
        }
    }
}
