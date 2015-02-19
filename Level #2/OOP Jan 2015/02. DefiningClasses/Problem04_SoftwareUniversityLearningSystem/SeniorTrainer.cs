using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_SoftwareUniversityLearningSystem;

namespace Problem04_SoftwareUniversityLearningSystem
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            :base(firstName,lastName,age)
        {

        }

        public void DeleteCourse(string courseName)
        {
            course.Remove(courseName);
        }
    }
}
