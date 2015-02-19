using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FitBoxInBox
{
    class FitBoxInBox
    {
        static void Main(string[] args)
        {
            int widthBox2 = int.Parse(Console.ReadLine());
            int HeightBox2 = int.Parse(Console.ReadLine());
            int DepthBox2 = int.Parse(Console.ReadLine());
            int widthBox1 = int.Parse(Console.ReadLine());
            int HeightBox1 = int.Parse(Console.ReadLine());
            int DepthBox1 = int.Parse(Console.ReadLine());

            if ((widthBox1 < widthBox2)&&(HeightBox1 < HeightBox2) && (DepthBox1<DepthBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",widthBox1,HeightBox1,DepthBox1,widthBox2,HeightBox2,DepthBox2);
            }
            if ((widthBox1 < widthBox2) && (HeightBox1 < DepthBox2) && (DepthBox1 < HeightBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", widthBox1, HeightBox1, DepthBox1, widthBox2, DepthBox2, HeightBox2);
            }
            if ((widthBox1 < HeightBox2) && (HeightBox1 < widthBox2) && (DepthBox1 < DepthBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", widthBox1, HeightBox1, DepthBox1, HeightBox2, widthBox2, DepthBox2);
            }
            if ((widthBox1 < HeightBox2) && (HeightBox1 < DepthBox2) && (DepthBox1 < widthBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", widthBox1, HeightBox1, DepthBox1, HeightBox2, DepthBox2, widthBox2);
            }
            if ((widthBox1 < DepthBox2) && (HeightBox1 < widthBox2) && (DepthBox1 < HeightBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", widthBox1, HeightBox1, DepthBox1, DepthBox2, widthBox2, HeightBox2);
            }
            if ((widthBox1 < DepthBox2) && (HeightBox1 < HeightBox2) && (DepthBox1 < widthBox2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", widthBox1, HeightBox1, DepthBox1, DepthBox2, HeightBox2, widthBox2);
            }
        }
    }
}
