using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Student
{
    public class Students
    {
        private string name;
        private int age;
        private double grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Students(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Grade: {grade}";
        }
    }
}
