using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 5.	Boolean Variable");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter your sex in format \"male\" or \"female\" ");
            string sex = Console.ReadLine();
            bool isFemale;
            if (sex == "Male" || sex == "male" ) 
            {
                isFemale = false;
                Console.WriteLine("Is Female: " + isFemale);
            }
            if (sex == "female" || sex == "Female")
            {
                isFemale = true;
                Console.WriteLine("Is Female: " +isFemale);
            }
        }
    }
}
