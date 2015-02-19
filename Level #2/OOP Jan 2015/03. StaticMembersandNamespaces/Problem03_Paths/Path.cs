using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Paths
{
    public static class Path
    {
        public static List<Point3D> points = new List<Point3D>();

        public static List<Point3D> Add(Point3D point) 
        {
            points.Add(point);

            return points;
        }

        public static List<Point3D> Remove(Point3D point)
        {
            points.Remove(point);
            return points;
        }

        public static List<Point3D> RemoveAll()
        {
            points.RemoveRange(0, points.Count);
            return points;
        }

        public static string Print()
        {
            string result = "";
            foreach (var point in points)
            {
                result += "Point(" + point.X + ", " + point.Y + ", " + point.Z + ")\n";
            }
            return result;
        }

        public static string[] ToArray()
        {
            List<string> result = new List<string>();
            foreach (var point in points)
            {
                result.Add("Point(" + point.X + ", " + point.Y + ", " + point.Z + ")\n");
            }
            return result.ToArray();
        }
    }
}
