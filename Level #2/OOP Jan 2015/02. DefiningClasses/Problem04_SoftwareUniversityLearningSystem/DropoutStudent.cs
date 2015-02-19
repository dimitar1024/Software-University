using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public string DropoutReason
        {
            get { return dropoutReason; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Dropout reason is empty");
                    }
                    else
                    {
                        dropoutReason = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string Reapply() 
        {
            return "First name: " + this.FirstName + "\nLast name: " + this.LastName + "\nAge: " + this.Age +
                "\nStudent number: " + this.StudentNumber + "\nAverage grade: " + this.AverageGrade +
                "\nDropout reason: " + this.DropoutReason + "\n ";
        }
    }
}
