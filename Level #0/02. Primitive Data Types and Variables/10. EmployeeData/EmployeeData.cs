using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 10.	Employee Data");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"A marketing company wants to keep record of its employees. Each record would have the following characteristics:
*   First name
*   Last name
*   Age (0...100)
*   Gender (m or f)
*   Personal ID number (e.g. 8306112507)
*   Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last  name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            string strId = Console.ReadLine();
            long id = long.Parse(strId);
            Console.WriteLine("Enter Unique employee number [27560000…27569999] UEN: ");
            long uen = long.Parse(Console.ReadLine());

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your acount is create!");
            Console.ResetColor();
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("   Welcome " + firstName + " " + lastName);
            if (age > 0 && age < 100)
            {
                Console.WriteLine("      Age: " + age);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Pleace enter age form interval [0..100]");
                Console.WriteLine();
            }
            if (sex == "Male" || sex == "male" || sex == "Female" || sex == "female")
            {
                Console.WriteLine("   Gender: " + sex);
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("The gender is invalid");
                Console.WriteLine();
            }
            if (strId.Length != 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Please enter ten-digit number");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("ID number: " + id);
            }
            if (uen > 27560000 && uen < 27569999)
            {
                Console.WriteLine("      UEN: " + uen);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Pleace enter number form interval [27560000…27569999]");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
