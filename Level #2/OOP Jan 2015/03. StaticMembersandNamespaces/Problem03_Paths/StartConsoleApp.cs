using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Paths;

namespace Problem03_Paths
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
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

            Path.Add(zero);
            Path.Add(firstPoint);
            Path.Add(secondPoint);
            Path.Add(thirdPoint);
            Path.Add(fourthPoint);
            Path.Add(fivethPoint);
            Path.Add(sixthPoint);
            Path.Add(seventhPoint);
            Path.Add(eighthPoint);
            Path.Add(ninethPoint);
            Path.Add(tenthPoint);

            Path.Remove(zero);

            //The text file is located in directory "Problem03_Paths/Path.txt"
            string path = "../../Path.txt";
            Storage.SaveInFile(path);

            Storage.LoadInFile(path);
            Console.WriteLine(Path.Print());

        }
    }
}
