using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_ClassStudent
{
    class StartTestStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Ivan", "Georgiev", 23, "012314", "0215645651", "ivan.georgiev@abv.bg", new List<int>() { 2, 3, 4, 6, 6 }, 2));
            students.Add(new Student("Kancho", "Ivanov", 21, "878514", "045765545", "kancho_ivanov@yahui.bg", new List<int>() { 2, 3, 4, 6, 6, 4, 5, 5, 5, 3, 2 }, 1));
            students.Add(new Student("Hristofor", "Kolumbieca", 18, "989708", "08465456456", "H.Kolumbieca@abv.bg", new List<int>() { 2, 3, 4, 5, 5, 5, 3, 2 }, 3));
            students.Add(new Student("Dinko", "Stefanov", 43, "021511", "+3592564564", "StefanovDinko@mail.bg", new List<int>() { 5, 5, 5, 3, 2 }, 2));
            students.Add(new Student("Kiro", "Papazov", 40, "056110", "01313132313", "KiroP@abv.bg", new List<int>() { 2, 3, 4, 6, 6, 4, 5, 5, 5, 3, 2 }, 1));
            students.Add(new Student("Galq", "Petrova", 25, "988202", "089545231321", "Galkataaa@abv.bg", new List<int>() { 2, 3 }, 1));
            students.Add(new Student("Slivka", "Veikova", 32, "987600", "0982313151231", "SkivMySliv@gmail.bg", new List<int>() { 2, 5, 5, 3, 2 }, 3));

            //Problem 04
            Console.WriteLine("Problem 04");
            Console.WriteLine(new string('*', 80));
            var studentsByGroup = from s in students
                                  where s.GroupNumber == 2
                                  orderby s.FirstName
                                  select s;


            foreach (var student in studentsByGroup)
            {
                Console.WriteLine(student);
            }

            //Problem 05
            Console.WriteLine("Problem 05");
            Console.WriteLine(new string('*', 80));
            var studentsByFirstAndLastName = from s in students
                                             where s.FirstName.CompareTo(s.LastName) < 0
                                             orderby s.FirstName
                                             select s;
            foreach (var student in studentsByFirstAndLastName)
            {
                Console.WriteLine(student);
            }


            //Problem 06
            Console.WriteLine("Problem 06");
            Console.WriteLine(new string('*', 80));
            var studentsByAge = from s in students
                                where 18 <= s.Age && s.Age <= 24
                                orderby s.FirstName
                                select new { s.FirstName, s.LastName };

            foreach (var student in studentsByAge)
            {
                Console.WriteLine(student);
            }

            //Problem 07
            Console.WriteLine("Problem 07");
            Console.WriteLine(new string('*', 80));
            var sortStudents = students.OrderBy(o => o.FirstName)
                                .ThenBy(o => o.LastName);

            foreach (var student in sortStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('*', 80));

            var sortStudentsLINQ = from s in students
                                   orderby s.FirstName, s.LastName
                                   select s;
            foreach (var student in sortStudentsLINQ)
            {
                Console.WriteLine(student);
            }

            //Problem 08
            Console.WriteLine("Problem 08");
            Console.WriteLine(new string('*', 80));
            var filterStudentsByEmailDomain = from s in students
                                              where s.Email.Contains("@abv.bg")
                                              orderby s.FirstName
                                              select s;
            foreach (var student in filterStudentsByEmailDomain)
            {
                Console.WriteLine(student);
            }

            //Problem 09
            Console.WriteLine("Problem 09");
            Console.WriteLine(new string('*', 80));
            var filterStudentsByPhone = from s in students
                                        where s.Tel.StartsWith("02") ||
                                        s.Tel.StartsWith("+3592") ||
                                        s.Tel.StartsWith("+359 2")
                                        select s;
            foreach (var student in filterStudentsByPhone)
            {
                Console.WriteLine(student);
            }

            //Problem 10
            Console.WriteLine("Problem 10");
            Console.WriteLine(new string('*', 80));
            var excellentStudents = from s in students
                                    where s.Marks.Contains(6)
                                    select s;
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student);
            }

            //Problem 11
            Console.WriteLine("Problem 11");
            Console.WriteLine(new string('*', 80));
            var weakStudents = from s in students
                               where s.Marks.Count == 2
                               select s;
            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
            }

            //Problem 12
            Console.WriteLine("Problem 12");
            Console.WriteLine(new string('*', 80));
            var studentsEnrolledIn2014 = from s in students
                                         where s.FN.EndsWith("14")
                                         select s;
            foreach (var student in studentsEnrolledIn2014)
            {
                Console.WriteLine(student);
            }


            // Problem 13
            Console.WriteLine("Problem 13");
            Console.WriteLine(new string('*', 80));
            var groupedByGroupName = from s in students
                                     group s by s.GroupNumber into g
                                     select new { GroupName = g.Key, students = g.ToList() };

            foreach (var student in groupedByGroupName)
            {
                Console.WriteLine(student.GroupName);
                foreach (var item in student.students)
                {
                    Console.WriteLine(item);
                }
            }


            // Problem 14
            Console.WriteLine("Problem 14");
            Console.WriteLine(new string('*', 80));

            var specialties = new List<StudentSpecialty>()
            {
            new StudentSpecialty("HTML & CSS", "012314"),
            new StudentSpecialty("PHP", "878514"),
            new StudentSpecialty("JAVA", "989708"),
            new StudentSpecialty("JavaScript", "021511"),
            new StudentSpecialty("PHP", "056110"),
            new StudentSpecialty("C#", "988202"),
            new StudentSpecialty("JAVA", "987600")
            };

            var studentSpecialty = from s in students
                                   join sp in specialties
                                   on s.FN equals sp.FacultyNumber
                                   orderby s.FirstName
                                   select new
                                   {
                                       FullName = s.FirstName + " " + s.LastName,
                                       FacNum = s.FN,
                                       Specialty = sp.SpecialtyName
                                   };

            foreach (var student in studentSpecialty)
            {
                Console.WriteLine(student);
            }
        }
    }
}
