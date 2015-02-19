using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {

        public LocalCourse(string courseName)
            : base(courseName)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName)
        {
            this.Students = students;
            this.Lab = null;
        }
    }
}
