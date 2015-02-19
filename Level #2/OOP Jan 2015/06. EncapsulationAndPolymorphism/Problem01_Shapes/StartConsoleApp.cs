using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Shapes
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            Triangle ABC = new Triangle(6, 9, 4, 5);
            shapes.Add(ABC);
            Triangle MNQ = new Triangle(5, 9, 6, 8);
            shapes.Add(MNQ);
            Triangle PRS = new Triangle(10, 6, 8, 6);
            shapes.Add(PRS);

            Rectangle ABCD = new Rectangle(8, 10);
            shapes.Add(ABCD);
            Rectangle EFGH = new Rectangle(4, 30);
            shapes.Add(EFGH);
            Rectangle WXYZ = new Rectangle(80, 100);
            shapes.Add(WXYZ);

            Circle R = new Circle(4);
            shapes.Add(R);
            Circle K = new Circle(10);
            shapes.Add(K);
            Circle M = new Circle(100);
            shapes.Add(M);

            foreach (var shape in shapes)
            {
                shape.CalculateArea();
                shape.CalculatePerimeter();
                Console.WriteLine(new string('*',80));
            }
        }
    }
}
