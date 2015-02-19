using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define an abstract class Human holding a first name and a last name.
//•	Define a class Student derived from Human that has a field faulty number (5-10 digits / letters).
//•	Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns the payment earned by hour by the worker. 
//•	Define the proper constructors and properties for the classes in your class hierarchy.
//•	Initialize a list of 10 students and sort them by faculty number in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by payment per hour in descending order.
//•	Merge the lists and then sort them by first name and last name.

namespace Problem02_HumanStudentAndWorker
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();

            Student angel = new Student("Angel", "Angelov", "1243534634");
            students.Add(angel);
            Student arif = new Student("Arif", "Arifov", "54575444");
            students.Add(arif);
            Student vasil = new Student("Vasil", "Vasilev", "86342334");
            students.Add(vasil);
            Student damqn = new Student("Damqn", "Danchev", "764574543");
            students.Add(damqn);
            Student dana = new Student("Dana", "Georgieva", "463574765");
            students.Add(dana);
            Student dimitar = new Student("Dimitar", "Georgiev", "453465654");
            students.Add(dimitar);
            Student eva = new Student("Eva", "Naidenova", "4645687223");
            students.Add(eva);
            Student ivan = new Student("Ivan", "Rosenov", "465765634");
            students.Add(ivan);
            Student ivanka = new Student("Ivanka", "Peicheva", "575767665");
            students.Add(ivanka);
            Student ivelina = new Student("Ivelina", "Stefanova", "575687975");
            students.Add(ivelina);

            Worker baiIvanSLopatata = new Worker("Ivan", "Karashika", 140, 8);
            workers.Add(baiIvanSLopatata);
            Worker georgi = new Worker("Georgi", "Kaluna", 240, 10);
            workers.Add(georgi);
            Worker kolyo = new Worker("Kolyo", "Mastikata", 120, 4);
            workers.Add(kolyo);
            Worker nakov = new Worker("Svetlin", "Nakov", 5000, 6);
            workers.Add(nakov);
            Worker doncho = new Worker("Doncho", "Minkov", 4000, 8);
            workers.Add(georgi);
            Worker nafarvorii = new Worker("Otec", "Nafarforii", 500, 12);
            workers.Add(nafarvorii);
            Worker shisho = new Worker("Shisho", "Bakshisho", 332, 9);
            workers.Add(shisho);
            Worker encho = new Worker("Encho", "Rakiikata", 1000, 14);
            workers.Add(encho);
            Worker kiro = new Worker("Kiro", "Bobkata", 450, 12);
            workers.Add(kiro);
            Worker dimo = new Worker("Dimo", "Smukacha", 120, 12);
            workers.Add(dimo);

            students = students.OrderBy(x => x.FacultyNumber).ToList();
            workers = workers.OrderByDescending(o => o.WorkHoursPerDay).ToList();


            //print in console

            Console.WriteLine("Students");
            Console.WriteLine(new string('*', 80));

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Workers");
            Console.WriteLine(new string('*',80));
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }


            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            Console.WriteLine();
            Console.WriteLine("Merge the lists and then sort them by first name and last name.");
            Console.WriteLine(new string('*', 80));

            foreach (var human in humans)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
