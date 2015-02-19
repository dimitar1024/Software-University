using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class CurrentStudent : Student
    {
        private string currentCourse;

        public string CurrentCourse
        {
            get { return currentCourse; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Current course is empty");
                    }
                    else
                    {
                        currentCourse = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName,lastName,age,studentNumber,averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }
    }
}
