namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Person> company = new List<Person>();

            Manager nakov = new Manager("Svetlin", "Nakov", 1, 10000, Employee.Department.Marketing);
            company.Add(nakov);
            Employee deqn = new Employee("Dean", "Danev", 23,1209,Employee.Department.Production);
            Employee alex = new Employee("Alex", "Svilarova", 54,3049,Employee.Department.Production);
            Employee petq = new Employee("Petq", "Grozdarska", 23, 2209, Employee.Department.Production);
            nakov.AddEmployeeToTeam(deqn);
            nakov.AddEmployeeToTeam(alex);
            nakov.AddEmployeeToTeam(petq);

            SalesEmployee hristo = new SalesEmployee("Hristo", "Ivanov", 2, 5000, Employee.Department.Sales);
            company.Add(hristo);
            DateTime data = DateTime.Parse("24.01.2015");
            Sale laptop = new Sale("HP Probook 450", data, 1300);
            Developer doncho = new Developer("Doncho", "Minkov", 132, 4000, Employee.Department.Production);
            company.Add(doncho);

            foreach (var item in company)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine(new string('+',80));
            Console.WriteLine("Nakov's team");
            Console.WriteLine(new string('+', 80));
            Console.WriteLine(nakov.PrintTeam());

        }
    }
}
