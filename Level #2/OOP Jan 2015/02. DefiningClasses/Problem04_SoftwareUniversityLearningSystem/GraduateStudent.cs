﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName,lastName,age,studentNumber,averageGrade)
        {

        }
    }
}
