using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_SoftwareUniversityLearningSystem;

namespace Problem04_SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        private string studentNumber;
        private double averageGrade;

        public string StudentNumber
        {
            get { return studentNumber; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Student number reason is empty");
                    }
                    else
                    {
                        studentNumber = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public double AverageGrade
        {
            get { return averageGrade; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Number of visits is negative number");
                    }
                    else
                    {
                        averageGrade = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            :base(firstName,lastName,age)
        {
            this.AverageGrade = averageGrade;
            this.StudentNumber = studentNumber;
        }
    }
}
