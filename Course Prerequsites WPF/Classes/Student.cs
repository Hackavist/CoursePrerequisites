using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Course_Prerequsites_WPF.UIs;

namespace Course_Prerequsites_WPF.Classes
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Course> FinishedCourses { get; set; }
        public int AcademicYear { get; set; }
        public List<Course> CoursesInProgress { get; set; }

        public Student()
        {
            Name = "";
            Id = "";
            Password = "";
            AcademicYear = 0;
            FinishedCourses = null;
            CoursesInProgress = null;
        }

        public Student(string id, string n, string pass, int year, List<Course> finished, List<Course> progess)
        {
            Name = n;
            Id = id;
            Password = pass;
            AcademicYear = year;
            FinishedCourses = finished;
            CoursesInProgress = progess;
        }

        public Student(string id, string n, string pass, int year)
        {
            Name = n;
            Id = id;
            Password = pass;
            AcademicYear = year;
        }

        //writing Format:   Id % Name % Password % AcademicYear % finishd course1 * finished course2 % Course in progress1*Course in progress2 #

        public Dictionary<string, Student> GetAllStudents()
        {
            Dictionary<string, Student> AllStudents = new Dictionary<string, Student>();

            List<Course> FinishedCourses = new List<Course>();
            List<Course> CoursesInProgress = new List<Course>();

            string[] Records;
            string[] fields;
            string[] List1;
            string[] List2;


            FileStream File = new FileStream("AllStudentsFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader Sr = new StreamReader(File);


            while (Sr.Peek() != -1)
            {
                Records = Sr.ReadLine().Split('#');
                for (int i = 0; i < Records.Length-1; i++)
                {
                    fields = Records[i].Split('%');

                    string Id = fields[0];
                    string Name = fields[1];
                    string PassWord = fields[2];
                    int AcademicYear = Convert.ToInt32(fields[3]);
                    List1 = fields[4].Split('*');
                    List2 = fields[5].Split('*');

                    foreach (var item in List1)
                    {
                        FinishedCourses.Add(WelcomePage.Course.ReturnObj(item));
                    }

                    foreach (var item in List2)
                    {
                        CoursesInProgress.Add(WelcomePage.Course.ReturnObj(item));
                    }

                    Student stud = new Student(Id, Name, PassWord, AcademicYear, FinishedCourses, CoursesInProgress);

                    AllStudents[Name] = stud;

                    FinishedCourses.Clear();
                    CoursesInProgress.Clear();

                }
            }

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

        //writing Format:   Id % Name % Password % AcademicYear % finishd course1 * finished course2 % Course in progress1*Course in progress2 #

        public void WriteFile()
        {
            if (WelcomePage.AllStudentsDictionary != null)
            {
                //counters for the * typing
                int c = 0,i=0;

                FileStream File = new FileStream("AllStudentsFile.txt", FileMode.Append, FileAccess.Write);
                StreamWriter Sw = new StreamWriter(File);

                //writes the data members of each student in the dictionary
                foreach (var stud in WelcomePage.AllStudentsDictionary.Values)
                {
                    Sw.Write(stud.Id);
                    Sw.Write('%');
                    Sw.Write(stud.Name);
                    Sw.Write('%');
                    Sw.Write(stud.Password);
                    Sw.Write('%');
                    Sw.Write(Convert.ToString(stud.AcademicYear));
                    Sw.Write('%');
                    //writes the finished courses
                    foreach (var item in stud.FinishedCourses)
                    {
                        c++;
                        Sw.Write(item.CourseName);
                        if (c != stud.FinishedCourses.Capacity - 1)
                        {
                            Sw.Write('*');
                        }
                    }
                    // writes the courses in progress
                    foreach (var item in stud.CoursesInProgress)
                    {
                        i++;
                        Sw.Write(item.CourseName);
                        if (i != stud.CoursesInProgress.Capacity - 1)
                        {
                            Sw.Write('*');
                        }
                    }
                    //end of record dilimter
                    Sw.Write('#');
                }

                //closes the stream writer and the file stream 
                Sw.Close();
                File.Close();
            }
            else
            {
                //throws an exceptions that says Unimplmented 
                throw new NotImplementedException();
            }
        }

    }
}


