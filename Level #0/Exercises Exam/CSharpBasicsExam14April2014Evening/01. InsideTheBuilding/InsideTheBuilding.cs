using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string[] outputs = new string[5];

            for (int i = 0; i < 5; i++)
			{
                int x = int.Parse(Console.ReadLine());
			    int y = int.Parse(Console.ReadLine());

                string now = "";
                if ((x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h))
                {
                    now = "inside";
                }
                else if ((x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h))
                {
                    now = "inside";
                }
                else if (!((x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h)))
                {
                    now = "outside";
                }
                else if (!((x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h)))
                {
                    now = "outside";
                }
                outputs[i] = now;
            }

            foreach (string n in outputs)
            {
                Console.WriteLine(n);
            }
        }
    }

