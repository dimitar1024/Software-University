using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentCables
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = -1;
            for (int i = 0; i < n; i++)
            {
                int width = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                

                if (width < 20 && type == "centimeters")
                {
                    continue;
                }
                if (type == "centimeters")
                {
                    sum += width;
                    count++;
                }
                if (type == "meters")
                {
                    sum += width * 100;
                    count++;
                }
            }
            int student = 0;
            sum = sum - (count * 3);
            student = sum / 504;

            int residue = sum - student * 504;

            Console.WriteLine(student);
            Console.WriteLine(residue);

        }
    }

