using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_SoftwareUniversityLearningSystem;

namespace Problem04_SoftwareUniversityLearningSystem
{
    public class Trainer : Person
    {
        public List<string> course = new List<string>();

        public Trainer(string firstName, string lastName, int age)
            :base(firstName,lastName,age)
        {

        }
        public virtual void CreateCourse( string courseName)
        {
            course.Add(courseName);
        }
    }
}
