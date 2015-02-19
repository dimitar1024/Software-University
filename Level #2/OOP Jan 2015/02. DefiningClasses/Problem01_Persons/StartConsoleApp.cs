using System;
using Problem01_Persons;

namespace Problem01_Persons
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 21);

            Console.WriteLine(pesho.ToString());

            Person bayganyo = new Person("Bay Ganyo", 32,"bay@ganyo");

            Console.WriteLine(bayganyo.ToString());
        }
    }
}
