using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_School
{
    public class Course
    {
        string name;
        int credits;
        int maxStudents;
        List<Student> students;

        public string Name {
            get { return name; }
            internal set { name = value; }
        }

        public int Credits {
            get { return credits; }
            internal set { credits = value; }
        }

        public int MaxStudents {
            get { return maxStudents; }
            internal set { maxStudents = value; }
        }

        public List<Student> Students {
            get { return students; }
            internal set { students = value; }
        }
    }
}
