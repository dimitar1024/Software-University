using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_AsynchronousTimer
{
    class StartTimer
    {
        

        static void Main()
        {
            AsyncTimer timer1 = new AsyncTimer(AsyncTimer.Write, 1000, 10);
            timer1.Start();
        }
    }
}
