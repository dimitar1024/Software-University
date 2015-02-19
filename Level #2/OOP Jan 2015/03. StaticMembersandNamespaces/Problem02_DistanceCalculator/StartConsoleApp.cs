using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_DistanceCalculator;

namespace Problem02_DistanceCalculator
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Point3D> points = new List<Point3D>();

            Point3D zero = Point3D.StartingPoint;
            Point3D firstPoint = new Point3D(3, 4, 5);
            Point3D secondPoint = new Point3D(21, 22, 25);
            Point3D thirdPoint = new Point3D(12, 16, 14);
            Point3D fourthPoint = new Point3D(21, 25, 26);
            Point3D fivethPoint = new Point3D(1, 2, 3);
            Point3D sixthPoint = new Point3D(54, 52, 57);
            Point3D seventhPoint = new Point3D(93, 94, 95);
            Point3D eighthPoint = new Point3D(36, 40, 41);
            Point3D ninethPoint = new Point3D(21, 22, 23);
            Point3D tenthPoint = new Point3D(36, 34, 23);
            
            points.Add(zero);
            points.Add(firstPoint);
            points.Add(secondPoint);
            points.Add(thirdPoint);
            points.Add(fourthPoint);
            points.Add(fivethPoint);
            points.Add(sixthPoint);
            points.Add(seventhPoint);
            points.Add(eighthPoint);
            points.Add(ninethPoint);
            points.Add(tenthPoint);


            for (int i = 0; i < points.Count-1; i++)
            {
                double result = 0;
                result = DistanceCalculator.Calculate(points[i], points[i+1]);
                Console.WriteLine("Distance between Point({0}) and Point({1}) is: {2:f2}",i,i+1, result);
            }

            
            

        }
    }
}
