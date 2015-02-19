using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class Triangle : BasicShape, IShape
    {
        private double leftThigh;
        private double rightThigh;
        
        public double LeftThigh
        {
            get { return leftThigh; }
            set { leftThigh = value; }
        }
        
        public double RightThigh
        {
            get { return rightThigh; }
            set { rightThigh = value; }
        }
        
        

        public Triangle(double width, double height, double leftThigh, double rightThigh)
            : base(width, height)
        {
            this.LeftThigh = leftThigh;
            this.RightThigh = rightThigh;
        }

        public void CalculateArea()
        {
            double a = this.RightThigh;
            double b = this.LeftThigh;
            double c = this.Width;
            double p = (a+b+c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Area of the triangle is {0:f2}", area);
        }

        public void CalculatePerimeter()
        {
            double a = this.RightThigh;
            double b = this.LeftThigh;
            double c = this.Width;
            double perimeter = a + b + c;
            Console.WriteLine("Perimeter of the triangle is {0:f2}", perimeter);
        }
    }
}
