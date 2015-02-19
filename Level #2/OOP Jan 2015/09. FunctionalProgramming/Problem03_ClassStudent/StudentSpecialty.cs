using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_ClassStudent
{
    class StudentSpecialty
    {
        private string specialtyName;
        private string facultyNumber;
        public StudentSpecialty(string specialtyName, string facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FacultyNumber can not be null or empty!");
                }
                this.facultyNumber = value;
            }
        }
        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SpecialtyName can not be null or empty!");
                }
                this.specialtyName = value;
            }
        }
    }
}
