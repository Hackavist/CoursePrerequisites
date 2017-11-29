﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Course_Prerequsites_WPF.Classes
{
    public class Course
    {
        public string Code { get; set; }
        public string CourseName { get; set; }
        public int MaximumNumberOfStudents { get; set; }
        public int CurrentNumberOfStudents { get; set; }
        public int PassingGrade { get; set; }
        public int CourseGrade { get; set; }
        public int Hours { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public List<string> PreRequiredCourses { get; set; }

        public Course()
        {
            Code = "";
            CourseName = "";
            MaximumNumberOfStudents = 0;
            CurrentNumberOfStudents = 0;
            PassingGrade = 0;
            CourseGrade = 0;
            Hours = 0;
            Instructor = "";
            Description = "";
        }

        public Course(string code, string coursename, int Maximumnumber, int CurrentNumber, int passinggrade, int coursegrade, int hours, string instructor, string description, List<string> pre)
        {
            Code = code;
            CourseName = coursename;
            MaximumNumberOfStudents = Maximumnumber;
            CurrentNumberOfStudents = CurrentNumber;
            PassingGrade = passinggrade;
            CourseGrade = coursegrade;
            Hours = hours;
            Instructor = instructor;
            Description = description;
            PreRequiredCourses = new List<string>();

            foreach (var item in pre)
            {
                PreRequiredCourses.Add(item);
            }
        }


        //returns a Dictionary that Contains all existing couses indexed by course name and Course object

        public Dictionary<string, Course> GetAllCourses()
        {
            FileStream fs = new FileStream("AllCoursesFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            // 3 string arrays to split the readings in 
            string[] fileds;
            string[] records;
            string[] prerequirds;

            //list of prerequired courses 
            List<string> pr = new List<string>();

            //Dictionary of objects <this is the return of the function>
            Dictionary<string, Course> M = new Dictionary<string, Course>();

            while (sr.Peek() != -1)
            {
                //splits the inputs into Courses (using the # delimter)
                records = sr.ReadLine().Split('#');

                //loops until it reaches the number of courses

                for (int i = 0; i < records.Length - 1; i++)
                {
                    //splits each course into number of feilds  
                    fileds = records[i].Split('%');
                    //the course details
                    Code = fileds[0];
                    CourseName = fileds[1];
                    MaximumNumberOfStudents = Convert.ToInt32(fileds[2]);
                    CurrentNumberOfStudents = Convert.ToInt32(fileds[3]);
                    PassingGrade = Convert.ToInt32(fileds[4]);
                    CourseGrade = Convert.ToInt32(fileds[5]);
                    Hours = Convert.ToInt32(fileds[6]);
                    Instructor = fileds[7];
                    Description = fileds[8];

                    //creates an array of the PreREquried subjects 
                    prerequirds = fileds[9].Split('*');

                    //fills the array that exists in the class with the one in the file
                    for (int j = 0; j < prerequirds.Length; j++)
                    {
                        pr.Add(prerequirds[j]);
                    }
                    //Creates a costume obkject of the courses class 
                    Course c = new Course(Code, CourseName, MaximumNumberOfStudents, CurrentNumberOfStudents, PassingGrade, CourseGrade, Hours, Instructor, Description, pr);

                    //emptys the list to avoid extra entries 
                    pr.Clear();
                    //adds it ot the Dictionary of Coures
                    M[CourseName] = c;

                }


            }
            //closes the stream reader and the file stream 
            sr.Close();
            fs.Close();

            //returns list of objs
            return M;

        }

        //Function takes the name and returnsthe object of it 
        public Course ReturnObj(string Name)
        {
            Dictionary<string, Course> Objects = GetAllCourses();//Read all Courses from file in a Dictionary 

            bool check = false;//To chaeck if this course exist or not

            foreach (var x in Objects)//loop to search for certaion subjects in all the subjects
            {
                if (x.Key == Name) // commpares the kety of the dictionary with the course's name
                {
                    check = true;
                    return x.Value; //retuns the object of the course
                }
            }
            if (check == false)
            {
                return null;
            }
            else return null;
        }

        public void WriteObj(Course cour)
        {
            if (cour != null)
            {
                FileStream File = new FileStream("AllCoursesFile.txt", FileMode.Append, FileAccess.Write);
                StreamWriter Sw = new StreamWriter(File);

                Sw.Write(cour.Code);
                Sw.Write('%');
                Sw.Write(cour.CourseName);
                Sw.Write('%');
                Sw.Write(Convert.ToString(cour.MaximumNumberOfStudents));//converts the intgers to strings then writes them in the file 
                Sw.Write('%');
                Sw.Write(Convert.ToString(cour.CurrentNumberOfStudents));//converts the intgers to strings then writes them in the file 
                Sw.Write('%');
                Sw.Write(Convert.ToString(cour.PassingGrade));//converts the intgers to strings then writes them in the file 
                Sw.Write('%');
                Sw.Write(Convert.ToString(cour.CourseGrade));//converts the intgers to strings then writes them in the file 
                Sw.Write('%');
                Sw.Write(Convert.ToString(cour.Hours));//converts the intgers to strings then writes them in the file 
                Sw.Write('%');
                Sw.Write(cour.Instructor);
                Sw.Write('%');
                Sw.Write(cour.Description);
                Sw.Write('%');

                //loops on the list of prequsites and add '*' delimiter between them
                foreach (var item in cour.PreRequiredCourses)
                {
                    Sw.Write(item);
                    Sw.Write('*');
                }

                //end of record dilimter
                Sw.Write('#');

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
