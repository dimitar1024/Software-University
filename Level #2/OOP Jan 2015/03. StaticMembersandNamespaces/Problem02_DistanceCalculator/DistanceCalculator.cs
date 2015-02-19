using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_DistanceCalculator;

namespace Problem02_DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double Calculate(Point3D a, Point3D b)
        {

            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
        }
    }
}
