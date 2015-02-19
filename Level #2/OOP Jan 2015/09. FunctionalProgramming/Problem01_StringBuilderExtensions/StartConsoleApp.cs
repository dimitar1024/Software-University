using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_StringBuilderExtensions
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            string abc = "Lorem ipsum";

            var str = new StringBuilder(abc);

            Console.WriteLine(str.Substring(0,5));
            Console.WriteLine(str.RemoveText("Lorem "));
            Console.WriteLine(str.AppendAll(" dolor sit amet"));
        }
    }
}
