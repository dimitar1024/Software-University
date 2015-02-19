using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Rectangle : BasicShape, IShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        public void CalculateArea()
        {
            double area = (this.Width * this.Height);
            Console.WriteLine("Area of the rectangle is {0:f2}", area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = (this.Width + this.Height) * 2;
            Console.WriteLine("Perimeter of the rectangle is {0:f2}", perimeter);
        }
    }
}
