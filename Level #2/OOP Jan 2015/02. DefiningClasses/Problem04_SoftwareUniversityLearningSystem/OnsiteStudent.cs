using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Number of visits is negative number");
                    }
                    else
                    {
                        numberOfVisits = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName,lastName,age,studentNumber,averageGrade,currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }
        
    }
}
