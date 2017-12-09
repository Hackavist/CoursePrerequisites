using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public Student()
        {
            Name = "";
            Id = "";
            Password = "";
            FinishedCourses = null;
            AcademicYear = 0;
            CoursesInProgress = null;
        }

        public Student(string n, string id, string pass, List<Course> finished, int year, List<Course> progess)
        {
            Name = n;
            Id = id;
            Password = pass;
            FinishedCourses = finished;
            AcademicYear = year;
            CoursesInProgress = progess;
        }

        public Student(string n , string id , string pass , int year)
        {
            Name = n;
            Id = id;
            Password = pass;
            AcademicYear = year;
        }

        //writing Format:   Id % Name % Password % AcademicYear % finishd course1 * finished course2 % Course in progress1*Course in progress2 #

        public Dictionary<string, Student> GetAllStudents()
        {
            FileStream File = new FileStream("AllStudents.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(File);

            // 3 string arrays to split the readings in 
            string[] Datamembes;
            string[] Records;
            string[] FirstListElements;
            string[] SecondListElements;

            //list of Finished Coures
            List<Course> FinisedCourses = new List<Course>();

            //list of Finished Coures
            List<Course> CoursesInProgress = new List<Course>();

            //Dictionary of objects <this is the return of the function>
            Dictionary<string, Student> AllStudents = new Dictionary<string, Student>();

            while (sr.Peek() != -1)
            {
                //splits The Record 
                Records = sr.ReadLine().Split('#');

                //Loops on all reacords 
                for (int i = 0; i < Records.Length-1; i++)
                {
                    //splits the Records into datamembers 
                    Datamembes = Records[i].Split('%');

                    Id = Datamembes[0];
                    Name = Datamembes[1];
                    Password = Datamembes[2];
                    AcademicYear = Convert.ToInt32(Datamembes[3]);
                    //emptyes the list into arrays 
                    FirstListElements = Datamembes[4].Split('*');
                    SecondListElements = Datamembes[5].Split('*');

                    //object to fill the list  
                    Course cour = new Course();

                    //populates the list of finished courses
                    for (int q = 0; q < FirstListElements.Length; q++)
                    {
                        FinisedCourses.Add(cour.ReturnObj(FirstListElements[i]));
                    }

                    // populates the list of current courses 
                    for (int l = 0; l < SecondListElements.Length; l++)
                    {
                        CoursesInProgress.Add(cour.ReturnObj(SecondListElements[l]));
                    }

                    Student Student = new Student(Name, Id, Password, FinishedCourses, AcademicYear, CoursesInProgress);

                    //clears the list in order to avoid extra entries bug 
                    FinisedCourses.Clear();
                    CoursesInProgress.Clear();

                    //addes the value to dictionary 
                    AllStudents[Name] = Student;
                }
            }
            //closes the file stream and stream reader 

            sr.Close();
            File.Close();

            return AllStudents;
        }




        //fixed the error by making a list of abjects 
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

