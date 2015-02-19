namespace Problem03_GenericList
{
    using System;
    using System.Collections.Generic;

    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            
            for (int i = 0; i < 15; i++)
            {
                list.Add(i);
            }
            
            
            list.Insert(1, 100);
            Console.WriteLine("Insert()");
            Console.WriteLine(list);

            Console.WriteLine("Max()");
            Console.WriteLine(list.Max());

            Console.WriteLine("Min()");
            Console.WriteLine(list.Min());
            
            Console.WriteLine("Find()");
            list.Find(1);
            
        }
    }
}
