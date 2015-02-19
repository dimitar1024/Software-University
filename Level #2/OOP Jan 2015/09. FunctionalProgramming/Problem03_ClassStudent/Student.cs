using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_ClassStudent
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string fname, string lname,int age, string fn, string tel, string email, List<int> marks, int group)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Faculty number: {2} Phone: {3} Group: {4}", this.FirstName, this.LastName, this.FN, this.Tel, this.GroupNumber);
        }
    }
}
