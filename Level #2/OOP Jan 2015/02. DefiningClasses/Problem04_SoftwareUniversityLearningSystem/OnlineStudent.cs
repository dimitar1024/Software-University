﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class OnlineStudent : CurrentStudent
    {

        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName,lastName,age,studentNumber,averageGrade,currentCourse)
        {
        }
    }
}
