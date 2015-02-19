using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public class Class
    {
        //props
        private string id;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        public string ID
        {
            get { return id; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("ID is Empty");
                    }
                    else
                    {
                        id = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //constructors
        public Class(string id)
        {
            this.ID = id;
        }

        //methods
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public string AllTeachers()
        {
            var allTeacher = new StringBuilder();

            foreach (var teacher in teachers)
            {
                allTeacher.AppendFormat(teacher.ToString() + "\n");
            }

            return allTeacher.ToString();
        }

        public string AllStudents()
        {
            var allStudents = new StringBuilder();

            foreach (var student in students)
            {
                allStudents.AppendFormat(student.ToString() + "\n");
            }

            return allStudents.ToString();
        }

        public override string ToString()
        {
            return this.ID + "\n";
        }
    }
}
