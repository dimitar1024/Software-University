using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Point3D
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Point3D> points = new List<Point3D>();

            Point3D zero = Point3D.StartingPoint;
            points.Add(zero);
            Point3D firstPoint = new Point3D(3, 4, 5);
            points.Add(firstPoint);
            Point3D secondPoint = new Point3D(21, 22, 25);
            points.Add(secondPoint);
            Point3D thirdPoint = new Point3D(12,16, 14);
            points.Add(thirdPoint);
            Point3D fourthPoint = new Point3D(21, 25, 26);
            points.Add(fourthPoint);
            Point3D fivethPoint = new Point3D(1, 2, 3);
            points.Add(fivethPoint);
            Point3D sixthPoint = new Point3D(54, 52, 57);
            points.Add(sixthPoint);
            Point3D seventhPoint = new Point3D(93, 94, 95);
            points.Add(seventhPoint);
            Point3D eighthPoint = new Point3D(36, 40, 41);
            points.Add(eighthPoint);
            Point3D ninethPoint = new Point3D(21, 22, 23);
            points.Add(ninethPoint);
            Point3D tenthPoint = new Point3D(36, 34, 23);
            points.Add(tenthPoint);

            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }
}
