using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Prerequsites_WPF.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public List<Course> FinishedCourses { get; set; }
        public int AcademicYear { get; set; }
        public List<Course> CoursesInProgress { get; set; }

        //created a default constructor
        public Student()
        {
            Name = "";
            Id = "";
            Password = "";
            FinishedCourses = new List<Course>() ;
            AcademicYear = 0;
            CoursesInProgress = new List<Course>();
        }


        public Student(string n, string id, string pass, List<Course>li, int year, List<Course>linprog)
        {
            Name = n;
            Id = id;
            Password = pass;
            FinishedCourses = li;
            AcademicYear = year;
            CoursesInProgress = linprog;
        }
 

        public bool CheckPrequired(string name)
        {
            Course Cs = new Course();
            Cs = Cs.ReturnObj(name);
            for (int i = 0; i < FinishedCourses.Capacity; i++)
            {
                bool found = false;
                for (int j = 0; j < Cs.PreRequiredCourses.Capacity; j++)
                {
                    if (FinishedCourses[i].CourseName == Cs.PreRequiredCourses[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    return false;
                }
            }
            return true;
        }



        public void Register(Course NewCourse)
        {
            //To be added: NewCourse.NumberOfRegisteredStudents
            if (CheckPrequired(NewCourse.CourseName) == true/* &&  NewCourse.MaximumNumberOfStudents - NewCourse.NumberOfRegisteredStudents*/)
            {
                CoursesInProgress.Add(NewCourse);
            }
        }

    }
}

