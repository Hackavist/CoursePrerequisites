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
        public string AcademicYear { get; set; }
        public List<Course> CoursesInProgress { get; set; }

        public Student()
        {
            Name = "";
            Id = "";
            Password = "";
            AcademicYear = "";
            FinishedCourses = new List<Course>();
            CoursesInProgress = new List<Course>();
        }

        public Student(string id, string name, string pass, string year)
        {
            Name = name;
            Id = id;
            Password = pass;
            AcademicYear = year;
            FinishedCourses = new List<Course>();
            CoursesInProgress = new List<Course>();

        }

        public Student(string id, string n, string pass, string year, List<Course> finished, List<Course> progess)
        {
            Name = n;
            Id = id;
            Password = pass;
            AcademicYear = year;
            FinishedCourses = new List<Course>();
            foreach (Course item in finished)
            {
                FinishedCourses.Add(item);
            }

            CoursesInProgress = new List<Course>();
            foreach (Course item in progess)
            {
                CoursesInProgress.Add(item);
            }
        }
        //writing Format:   Id % Name % Password % AcademicYear % finishd course1 * finished course2 % Course in progress1*Course in progress2 #

        public Dictionary<string, Student> GetAllStudents()
        {
            Dictionary<string, Student> AllStudents = new Dictionary<string, Student>();
            FileStream File = new FileStream("AllStudentsFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader Sr = new StreamReader(File);
            string[] Records;
            while (Sr.Peek() != -1)
            {
                Records = Sr.ReadLine().Split('#');
                for (int i = 0; i < Records.Length - 1; i++)
                {
                    List<Course> FinishedCourses = new List<Course>();
                    List<Course> CoursesInProgress = new List<Course>();

                    string[] fields;
                    string[] List1;
                    string[] List2;
                    fields = Records[i].Split('%');

                    string Id = fields[0];
                    string Name = fields[1];
                    string PassWord = fields[2];
                    string AcademicYear = fields[3];
                    List1 = fields[4].Split('*');
                    List2 = fields[5].Split('*');

                    foreach (var item in List1)
                    {
                        if (item != "")
                        {
                            FinishedCourses.Add(WelcomePage.Course.ReturnObj(item));

                        }
                    }

                    foreach (var item in List2)
                    {
                        if (item != "")
                        {
                            CoursesInProgress.Add(WelcomePage.Course.ReturnObj(item));

                        }
                    }
                    Student stud = new Student(Id, Name, PassWord, AcademicYear, FinishedCourses, CoursesInProgress);

                    AllStudents[Id] = stud;

                    FinishedCourses.Clear();
                    CoursesInProgress.Clear();

                }
            }

            Sr.Close();
            File.Close();

            return AllStudents;

        }
        //Function that check if this student have 20 hr or more in one semster 
        public bool IsAvailableCreditHours(Student s, Course c)
        {
            //we make total hours = to el hours of selected course in combo box to make check if it's hours is suitable or not.
            int TotalHours = c.Hours;
            
            //Loop to add the hours of all the courses in progress to get all the hours of the student + the hours of the course he want to register for
            //and see if he is allowed to make reister for it or no
            foreach (var x in s.CoursesInProgress)
            {

               TotalHours += x.Hours;
            }

            if (TotalHours > 20)

                return false;

            else

                return true;

        }
        //Function that Check if this student take all the prerequisites of the course to make it available for him
        public bool CheckPrequired(string name)
        {
            //Make object of type Course
            Course Cs = new Course();
            //Call the function of ReturnObj to get all the details related to it
            Cs = Cs.ReturnObj(name);


            //loop till the number of prequisite of this course
            for (int j = 0; j < Cs.PreRequiredCourses.Count; j++)
            {

                bool found = false;
                //loop till the number of finished courses 
                for (int i = 0; i < WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].FinishedCourses.Count; i++)
                {
                    //Check if the prerequired courses of this course are in the finished courses or not
                    if (WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].FinishedCourses[i].CourseName == Cs.PreRequiredCourses[j])
                    {
                        found = true;

                    }
                }

                if (found == false)
                {
                    return false;
                }
            }
            return true;
        }
        //Function that check if aspecific Course for aspecific student is in the courses in progress or not
        public bool CheckIfCourseInProgress(Student s, string coursenam)
        {
            //Loop that loop in every item in the courses in progress
            foreach (var x in s.CoursesInProgress)
            {
                //if the course we sent in the paramter is in the courses in progress it return true 
                if (x.CourseName == coursenam)
                    return true;
            }
            return false;
        }
        //Function that check if aspecific Course for aspecific student is in the finished courses or not
        public bool FinishedCoursesCheck(Student s, string coursenam)
        {
            //Loop that loop in every item in the finished courses
            foreach (var x in s.FinishedCourses)
            {
                //if the course we sent in the paramter is in the finished courses it return true 
                if (x.CourseName == coursenam)
                    return true;
            }
            return false;
        }
        //The Main Function that return a list of available courses for aspecific student
        public List<string> ShowAvailableCourses()
        {
            List<string> l = new List<string>();
            Student s = new Student();
           
                //If this sudent doesn't take any courses yet(no courses in progress or in finished)
                if (WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].FinishedCourses.Count == 0 && WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].CoursesInProgress.Count == 0)
                {
                    //Loop on all existing couses in the dicionary
                    foreach (var x in WelcomePage.AllCoursesDictionary)
                    {
                        //Only the courses that is'nt full and has no preuisites courses will be added to the list 
                        if ((x.Value.CurrentNumberOfStudents < x.Value.MaximumNumberOfStudents) && (x.Value.PreRequiredCourses.Count == 0))

                        {

                            l.Add(x.Key);
                        }

                    }
                }
                //If this Student take courses in progress and no finished courses
                else if (WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].FinishedCourses.Count == 0 && WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].CoursesInProgress.Count != 0)
                {

                    //Loop on all existing couses in the dicionary
                    foreach (var x in WelcomePage.AllCoursesDictionary)
                    {

                        {
                            //Only the courses that is'nt full and has no preuisites courses will be added to the list  and not exist in the courses in progess will be added to the list 
                            if ((x.Value.CurrentNumberOfStudents < x.Value.MaximumNumberOfStudents) && (x.Value.PreRequiredCourses.Count == 0) && (s.CheckIfCourseInProgress(WelcomePage.AllStudentsDictionary[WelcomePage.StudentId], x.Value.CourseName) == false))

                            {

                                l.Add(x.Key);
                            }
                        }

                    }


                }
                //If this student have courses in both finished and in progress
                else
                {
                    //Loop on all existing couses in the dicionary
                    foreach (var x in WelcomePage.AllCoursesDictionary)
                    {

                        //Only the courses that is'nt full and not exist in the courses in progress and not exist in the finished courses and its prequired courses are already taken will be added to the list
                        if ((x.Value.CurrentNumberOfStudents < x.Value.MaximumNumberOfStudents) && (s.CheckIfCourseInProgress(WelcomePage.AllStudentsDictionary[WelcomePage.StudentId], x.Value.CourseName) == false) && (s.FinishedCoursesCheck(WelcomePage.AllStudentsDictionary[WelcomePage.StudentId], x.Value.CourseName) == false) && (s.CheckPrequired(x.Value.CourseName) == true))


                        {

                            l.Add(x.Key);

                        }


                    }
                }

                //return the list of all available courses for this student and appear in combo box
                return l;
           
        }

        //writing Format:   Id % Name % Password % AcademicYear % finishd course1 * finished course2 % Course in progress1*Course in progress2 #

        public void WriteFile()
        {
            if (WelcomePage.AllStudentsDictionary != null)
            {
                //counters for the * typing
                int c = 0, i = 0;

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
                    Sw.Write(stud.AcademicYear);
                    Sw.Write('%');

                    //writes the finished courses
                    foreach (var item in stud.FinishedCourses)
                    {
                        c++;
                        Sw.Write(item.CourseName);
                        if (c <= stud.FinishedCourses.Count - 1)
                        {
                            Sw.Write('*');
                        }
                    }
                    Sw.Write('%');
                    // writes the courses in progress
                    foreach (var item in stud.CoursesInProgress)
                    {
                        i++;
                        Sw.Write(item.CourseName);
                        if (i <= stud.CoursesInProgress.Count - 1)
                        {
                            Sw.Write('*');
                        }
                    }
                    //end of record dilimter
                    Sw.Write('#');
                    c = 0;
                    i = 0;
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

        public void FileClear()
        {
            File.WriteAllText(@"AllStudentsFile.txt", string.Empty);
        }

    }
}


