using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 2.	Print Company Information");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.");
            Console.WriteLine(new string('=', 80));

            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            ulong phoneNumber = ulong.Parse(Console.ReadLine());
            ulong? faxNumber = ulong.Parse(Console.ReadLine());
            
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            ulong managerPhone = uint.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel: +{0:### ### ## ## ##}", phoneNumber);
            Console.WriteLine("Fax: +{0:### ### ## ## ##}", faxNumber);
            Console.WriteLine("          Web site: {0}", website);
            Console.Write("Manager: {0} {1} ( age: {2} tel. +{3:### ### ## ## ##})", managerFirstName,managerLastName,managerAge,managerPhone);


        }
    }
}
