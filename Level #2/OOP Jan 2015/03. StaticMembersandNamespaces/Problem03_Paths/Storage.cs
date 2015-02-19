using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Paths;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem03_Paths
{
    public static class Storage
    {
        // using statement is used with StreamReader, but I used File.ReadAllLines and File.WriteAllLines
        public static void SaveInFile(string path)
        {
            string[] text = Path.ToArray();
            File.WriteAllLines(path, text);
        }

        public static void LoadInFile(string path)
        {
            Path.RemoveAll();
            string[] points = File.ReadAllLines(path);

            foreach (var point in points)
            {
                Match match = Regex.Match(point, @"Point\((\d.*)\s*,\s*(\d.*)\s*,\s*(\d.*)\)\s*",
                    RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    double x = double.Parse(match.Groups[1].Value);
                    double y = double.Parse(match.Groups[2].Value);
                    double z = double.Parse(match.Groups[3].Value);
                    Point3D p = new Point3D(x, y, z);
                    Path.Add(p);
                }

            }
        }
    }
}
