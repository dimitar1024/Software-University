using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01_School;

//We are given a school. In the school, there are classes of students. 
//•	Each class has a set of teachers. 
//•	Each teacher teaches a set of disciplines. 
//•	Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and students. Both teachers and students are people.
//Students, classes, teachers and disciplines have details (optional field).
//Your task is to identify the classes (in terms of OOP) and their members, encapsulate their fields,
//define the class hierarchy inherit shared data and functionality) and create a class diagram with Visual Studio.

namespace Problem01_School
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Discipline> disciplines = new List<Discipline>();
            List<Teacher> teachers = new List<Teacher>();

            Student andel = new Student(1,"angel", "angelov", 22, "0883463431", "bai@ivxcvdcban.bg");
            andel.ToString();
            Student arif = new Student(2,"arif", "arifov", 23, "08364343431", "bai@ivan.bg");
            Student vasil = new Student(3,"vasil", "jelqzkov", 21, "083634631", "bai@idfsdn.bg");
            Student damqn = new Student(4,"damqn", "danchev", 20, "0887344461", "bai@isdvsd.bg");
            Student dana = new Student(5,"dana", "georgieva", 22, "0887413131", "bsfvdf@ifvd.bg");
            Student dimitar = new Student(6,"dimitar", "georgiev", 23, "0887413131", "bdfbd@ivsdfsdf.bg");
            Student evdokiq = new Student(7,"eva", "naidenova", 21, "0887413131", "bai@ivdfdfbdfn.bg");
            Student ivan = new Student(8,"ivan", "kojuharov", 21, "08854645131", "bai@ivadfbdn.bg");
            Student ivelina = new Student(9,"ivelina", "stefanova", 22, "0887545464", "bai@ivafbdfn.bg");
            Student ivanka = new Student(10,"ivanka", "pei4eva", 23, "0887413131", "bai@ivsdvsan.bg");
            Student kaloqn = new Student(11,"kaloqn", "vasilev", 20, "08874346341", "bai@isdvan.bg");
            Student krisa = new Student(12,"kisa", "dimitrova", 24, "088741346341", "bai@ivasdvsn.bg");
            Student kristin = new Student(13,"kristina", "raicheva", 25, "08874634131", "basdsdi@ivan.bg");
            Student marina = new Student(14,"marina", "shandanova", 21, "088744361", "bsdvbsdfai@ivan.bg");
            Student mihaela = new Student(15,"miha", "mihailova", 20, "08874463431", "sabsdsdsdai@ivan.bg");
            Student stefko = new Student(16,"stefko", "petrov", 20, "08874641", "asfdgbai@ivsdvsdfan.bg");
            Student teda = new Student(17,"teda", "georgieva", 21, "08874463431", "sdvsdbai@isdsvan.bg");

            students.Add(andel);
            students.Add(arif);
            students.Add(vasil);
            students.Add(damqn);
            students.Add(dana);
            students.Add(dimitar);
            students.Add(evdokiq);
            students.Add(ivan);
            students.Add(ivelina);
            students.Add(ivanka);
            students.Add(kaloqn);
            students.Add(krisa);
            students.Add(kristin);
            students.Add(marina);
            students.Add(mihaela);
            students.Add(stefko);
            students.Add(teda);

            Discipline bgl = new Discipline("Bulgarian language",84);
            bgl.AddStudent(mihaela);
            bgl.AddStudent(ivelina);
            Discipline enl = new Discipline("English language", 224);
            enl.AddStudent(ivan);
            enl.AddStudent(kristin);
            enl.AddStudent(mihaela);
            enl.AddStudent(dana);
            Discipline math = new Discipline("Math",124);
            math.AddStudent(dimitar);
            math.AddStudent(dana);
            math.AddStudent(evdokiq);
            Discipline geo = new Discipline("Geographic", 64);
            geo.AddStudent(dimitar);
            geo.AddStudent(damqn);
            geo.AddStudent(stefko);
            Discipline bio = new Discipline("Biology", 24);
            bio.AddStudent(dimitar);
            bio.AddStudent(ivan);
            bio.AddStudent(vasil);
            Discipline chemistry = new Discipline("Chemistry", 24);
            chemistry.AddStudent(dimitar);
            chemistry.AddStudent(ivan);
            Discipline art = new Discipline("Art", 304);
            art.AddStudent(dimitar);
            art.AddStudent(marina);
            art.AddStudent(dana);
            art.AddStudent(mihaela);
            Discipline physics = new Discipline("Physics", 24);
            physics.AddStudent(dimitar);
            physics.AddStudent(stefko);
            

            Teacher bglTeacher = new Teacher("Danka", "Koleva", 54, "33234553453", "dkoleva@abv.bg");
            bglTeacher.AddDiscipline(bgl);
            teachers.Add(bglTeacher);
            Teacher enlTeacher = new Teacher("Svetla", "Petrova", 24, "45345344453", "spetrova@abv.bg");
            enlTeacher.AddDiscipline(enl);
            teachers.Add(enlTeacher);
            Teacher mathTeacher = new Teacher("Milena", "Dineva", 44, "12324233254", "milenad@abv.bg");
            mathTeacher.AddDiscipline(math);
            teachers.Add(mathTeacher);
            Teacher geoTeacher = new Teacher("Maria", "Mincheva", 34, "5635654454", "mmincheva@abv.bg");
            geoTeacher.AddDiscipline(geo);
            teachers.Add(geoTeacher);
            Teacher bioTeacher = new Teacher("Rosica", "Jecheva", 32, "57457564576", "biojecheva@abv.bg");
            bioTeacher.AddDiscipline(bio);
            teachers.Add(bioTeacher);
            Teacher chemistryTeacher = new Teacher("Todorka", "Pencheva", 54, "564534355354", "t.pencheva@abv.bg");
            chemistryTeacher.AddDiscipline(chemistry);
            teachers.Add(chemistryTeacher);
            Teacher artTeacher = new Teacher("Atanas", "Zoev", 57, "4657568i7856", "azoev.art@abv.bg");
            artTeacher.AddDiscipline(art);
            teachers.Add(artTeacher);
            Teacher physicsTeacher = new Teacher("Veselina", "Shishmanova", 39, "54357357554", "shishmanova.v@abv.bg");
            physicsTeacher.AddDiscipline(physics);
            teachers.Add(physicsTeacher);
            

            Class clas = new Class("12A"); // variable is written with a single "s", because two "ss" is the key word.

            foreach (var student in students)
            {
                clas.AddStudent(student);
            }

            foreach (var teacher in teachers)
            {
                clas.AddTeacher(teacher);
            }

            AllClasses.AddClass(clas);


            //Print all info.
            Console.WriteLine("Class");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(clas.AllStudents());
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Teachers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(clas.AllTeachers());
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Disciplines");
            Console.WriteLine(new string('=', 80));
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.PrintDiscipline());
            }
            Console.WriteLine(new string('=', 80));
            
        }
    }
}
