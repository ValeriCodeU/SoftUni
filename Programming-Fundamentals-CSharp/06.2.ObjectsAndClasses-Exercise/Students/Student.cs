using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        public Student(string firstname, string lastname, double grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }


        public override string ToString()
        {
            //"{first name} {second name}: {grade}"
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
