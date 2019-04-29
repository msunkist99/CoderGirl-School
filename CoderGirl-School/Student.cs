using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_School
{
    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits;
        double gpa;

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            internal set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            internal set { numberOfCredits = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

    }
}
