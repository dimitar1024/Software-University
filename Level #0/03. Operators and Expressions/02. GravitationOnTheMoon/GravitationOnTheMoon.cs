using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 2.	Gravitation on the Moon");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. ");
            Console.WriteLine(new string('=', 80));

            double number;
            do
            {
                Console.WriteLine("Enter weight from the Earth:");
                number = double.Parse(Console.ReadLine());
                number = number * 0.17d;
                Console.WriteLine("Weight of a man on the moon is: " + number + " kg");
                Console.WriteLine();
            } while (number is double);

            // do while цикъла съм го поставил за да проверявате повече числа с едно стартиране на програмата.
            // няма нищо общо с работата на програмата :)
        }
    }
}
