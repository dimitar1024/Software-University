using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_DistanceCalculator
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startingPoint = new Point3D(0,0,0);

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return "Point(" + this.X + "," + this.Y + "," + this.Z + ")";
        }
        
        
    }
}
