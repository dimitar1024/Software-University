using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem02_AsynchronousTimer
{
    class AsyncTimer
    {
        private Action<string> method;
        private int interval;
        private int ticks;

        public AsyncTimer(Action<string> method, int interval, int ticks)
        {
            this.ticks = ticks;
            this.interval = interval;
            this.method = method;
        }
        private void Counter()
        {
            Console.WriteLine("Start Timer!");
            while (this.ticks > 0)
            {
                Thread.Sleep(this.interval);
                if (method != null)
                {
                    Console.Clear();
                    method("Timer: " + this.ticks + "s");
                }
                this.ticks--;
            }
            Console.WriteLine("End");
        }
        public void Start()
        {
            Thread thread = new Thread(this.Counter);
            thread.Start();
        }

        public static void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
