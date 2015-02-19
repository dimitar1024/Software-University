using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HouseWithAWindow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int heightRoof = n;

            for (int i = 0; i < heightRoof; i++)
            {
                int could = 0;
                int inside = 0;
                string couldStr = "";
                string insideStr = "";
                int roof = 0;
                int j = i + 2;
                string roofStr = "";
                if (i == 0)
                {
                    could = (width - 1) / 2;
                    roof = 1;
                    couldStr = new string('.', could);
                    roofStr = new string('*', roof);
                    Console.Write(couldStr);
                    Console.Write(roofStr);
                    Console.WriteLine(couldStr);
                }

                if ((i < heightRoof) && !(i == 0))
                {
                    could = (width - (1 + i * 2)) / 2;
                    roof = 1;
                    inside = 1 + ((i - 1) * 2);
                    couldStr = new string('.', could);
                    roofStr = new string('*', roof);
                    insideStr = new string('.', inside);
                    Console.WriteLine("{0}{1}{2}{1}{0}", couldStr, roofStr, insideStr);
                }
            }
            Console.WriteLine(new string('*',width));

            int heigth = n;
            int window = n / 2;
            int windowsWidth = n - 3;
            int wall = (n - window) / 2;


            for (int i = 0; i < heigth; i++)
            {
                int walls = width - 2;
                string wallsStr = "";
                if (i < wall)
                {
                    wallsStr = new string('.', walls);
                    Console.WriteLine("*{0}*",wallsStr);
                }
                if ((i>= wall)&&(i <wall+window))
                {
                    walls = (walls - windowsWidth)/2;
                    wallsStr = new string('.', walls);
                    Console.Write("*{0}",wallsStr);
                    Console.Write(new string('*',windowsWidth));
                    Console.WriteLine("{0}*", wallsStr);
                }


                if (i >= wall+window)
                {
                    wallsStr = new string('.', walls);
                    Console.WriteLine("*{0}*", wallsStr);
                }
            }
            Console.WriteLine(new string('*', width));
        }
    }

