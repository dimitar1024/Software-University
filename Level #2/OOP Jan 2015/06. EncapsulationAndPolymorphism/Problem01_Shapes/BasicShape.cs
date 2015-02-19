using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Width is positive number");
                    }
                    else
                    {
                        width = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Height is positive number");
                    }
                    else
                    {
                        height = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
