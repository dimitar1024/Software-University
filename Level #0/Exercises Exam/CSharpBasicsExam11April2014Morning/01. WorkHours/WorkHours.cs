using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int hoursProject = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            
            decimal workDay = days*0.9m;
            decimal work = Math.Floor(workDay*12 * percent/100m);
            

            if (work <=hoursProject)
            {
                Console.WriteLine("No");
                int value = hoursProject-(int)work;
                Console.WriteLine("-"+value);
                
            }
            if (work > hoursProject)
            {
                Console.WriteLine("Yes");
                int diff = Math.Abs((int)work - hoursProject);
                Console.WriteLine(diff);
            }
        }
    }
}
