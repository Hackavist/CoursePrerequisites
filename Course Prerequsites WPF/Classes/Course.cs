using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Prerequsites_WPF.Classes
{
    class Course
    {
        public string Code { get; set; }
        public string CourseName { get; set; }
        public string MaximumNumberOfStudents { get; set; }
        public string PassingGrade { get; set; }
        public string CourseGrade { get; set; }
        public string Hours { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public List<string> PreRequiredCourses { get; set; }

        Course(string code, string coursename, string Maximumnumber, string passinggrade, string coursegrade, string hours, string instructor, string description, List<string> pre)
        {
            Code = code;
            CourseName = coursename;
            MaximumNumberOfStudents = Maximumnumber;
            PassingGrade = passinggrade;
            CourseGrade = coursegrade;
            Hours = hours;
            Instructor = instructor;
            Description = description;
            PreRequiredCourses = pre; 
        }





    }
}
