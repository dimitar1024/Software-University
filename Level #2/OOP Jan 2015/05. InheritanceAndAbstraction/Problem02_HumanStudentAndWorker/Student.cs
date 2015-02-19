using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber ;

        public string FacultyNumber 
        {
            get { return facultyNumber ; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Faculty number is Empty");
                    }

                    if (value.Length < 5 && value.Length > 10)
                    {
                        throw new ArgumentOutOfRangeException("Please enter faculty number with length between 5 ... 10");
                    }
                    
                        facultyNumber = value;
                    
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Faculty number: {2}",this.FirstName,this.LastName,this.FacultyNumber);
        }
    }
}
