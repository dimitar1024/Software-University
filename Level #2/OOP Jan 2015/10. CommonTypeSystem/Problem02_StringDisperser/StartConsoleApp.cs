namespace Problem02_StringDisperser
{
    using System;
    using System.Collections.Generic;

    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
                
            }
            Console.WriteLine();
        }
    }
}
