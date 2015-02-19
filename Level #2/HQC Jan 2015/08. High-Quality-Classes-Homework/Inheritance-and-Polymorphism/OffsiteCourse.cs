using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string courseName)
            : base(courseName)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Students = new List<string>();
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName)
        {
            this.Students = students;
            this.Town = null;
        }
    }
}
