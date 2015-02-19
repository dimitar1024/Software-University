using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students = new List<Student>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }

        //methods
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public string PrintStudents() 
        {
            var allStudents = new StringBuilder();

            foreach (var student in students)
            {
                allStudents.AppendFormat(student.ToString() + "\n");
            }

            return allStudents.ToString();
        }

        public Discipline(string name, int numberOfLectures)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;

        }
        public override string ToString()
        {
            return string.Format("Name: {0} count: {1} sudents: {2}", this.Name, this.NumberOfLectures, this.students.Count);
        }
        
    }
}
